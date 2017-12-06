using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WikiaClientLibrary;

namespace WikiDeck
{
    public partial class FormMain : Form
    {
        private WikiaClient _client;
        private Cards _cards;
        private Decks _decks;
        private Deck _deck;
        private string _deckPrefix;
        private string _deckListsPageName;
        private string _userName;

        public FormMain(string deckPrefix, string deckListsPageName)
        {
            InitializeComponent();
            _deckPrefix = deckPrefix;
            _deckListsPageName = deckListsPageName;
            SetCardCountText(0);
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            ValidateDeck();
        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            FormChooseDeck dlg = new FormChooseDeck(_decks);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Deck deck = new Deck(new WikiaPage(_client, _deckPrefix + dlg.ChosenDeck), dlg.ChosenDeck);
                UpdateUI(true);
                try
                {
                    await deck.LoadAsync();
                    _deck = deck;
                    richTextBoxDeck.Text = deck.Cards;
                    textBoxDeckName.Text = dlg.ChosenDeck;
                    ValidateDeck();
                }
                catch (WebException)
                {
                    ShowMessage("There was a network error while loading the deck.");
                    _deck = null;
                    richTextBoxDeck.Text = "";
                    textBoxDeckName.Text = "";
                }
                UpdateUI(false);
            }
        }

        private ValidateDeckResult ValidateDeck()
        {
            int cardCount = 0;
            ValidateDeckResult result = ValidateDeckResult.Valid;
            char[] sep = { '\n' };
            string[] cardLines = richTextBoxDeck.Text.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            richTextBoxDeck.Text = "";
            Regex cardEntry = new Regex(@"^(\d+)\s*x?\s+(.+)$");
            foreach (string line in cardLines)
            {
                string trimmedLine = line.Trim();
                if (trimmedLine.Length == 0)
                    continue; // foreach
                Match match = cardEntry.Match(trimmedLine);
                if (!match.Success)
                {
                    richTextBoxDeck.AppendText(trimmedLine, Color.Red);
                    richTextBoxDeck.AppendText("\n");
                    result |= ValidateDeckResult.BadFormat;
                    continue;
                }

                int amount;
                if (!int.TryParse(match.Groups[1].Value, out amount) || amount < 0)
                {
                    richTextBoxDeck.AppendText(trimmedLine, Color.Red);
                    richTextBoxDeck.AppendText("\n");
                    result |= ValidateDeckResult.BadFormat;
                    continue;
                }
                cardCount += amount;

                Card card = _cards.GetByName(match.Groups[2].Value);
                if (card == null)
                {
                    richTextBoxDeck.AppendText(trimmedLine, Color.Blue);
                    richTextBoxDeck.AppendText("\n");
                    result |= ValidateDeckResult.UnknownCard;
                    continue;
                }

                if (richTextBoxDeck.Text.IndexOf(card.Name, StringComparison.InvariantCultureIgnoreCase) != -1)
                {
                    richTextBoxDeck.AppendText(trimmedLine, Color.Tomato);
                    richTextBoxDeck.AppendText("\n");
                    result |= ValidateDeckResult.ContainsDuplicates;
                    continue;
                }

                if (amount > card.MaxInHand)
                {
                    richTextBoxDeck.AppendText(trimmedLine, Color.DarkViolet);
                    richTextBoxDeck.AppendText("\n");
                    result |= ValidateDeckResult.MaxInHandExceeded;
                    continue;
                }

                string correctCaseLine = match.Groups[1].Value + " " + card.Name;
                richTextBoxDeck.AppendText(correctCaseLine, Color.Green);
                richTextBoxDeck.AppendText("\n");
            }
            if (cardCount < 60)
                result |= ValidateDeckResult.LessThan60Cards;
            SetCardCountText(cardCount);
            return result;
        }

        private void SetCardCountText(int cardCount)
        {
            labelCardCount.Text = "Card Count " + cardCount.ToString();
        }

        private async void buttonUpload_Click(object sender, EventArgs e)
        {
            ValidateDeckResult valid = ValidateDeck();
            if (!ShouldContinueWithUpload(valid))
                return;
            UpdateUI(true);
            _deck.Cards = richTextBoxDeck.Text;
            try
            {
                await _deck.UploadAsync();
                ShowMessage("Deck has been uploaded.");
            }
            catch (WikiaEditConflictException)
            {
                ShowMessage("Unable to upload. Someone else is editing this deck. Please use 'view' to check their changes before trying again.");
            }
            catch (WikiaEditException ex)
            {
                if (ex.ErrorCode == "blocked")
                    BlockedUser(); // will exit app
                ShowMessage("Upload failed. " + ex.Message);
            }
            catch (WebException)
            {
                ShowMessage("Upload failed due to a network error.");
            }
            UpdateUI(false);
        }

        private bool ShouldContinueWithUpload(ValidateDeckResult valid)
        {
            if ((valid & ValidateDeckResult.BadFormat) != 0)
            {
                ShowMessage("The deck contains entries with an invalid format (shown in red). Please correct them before uploading.");
                return false;
            }
            else if (valid != ValidateDeckResult.Valid)
            {
                if (ShowMessage(ContinueUploadMessage(valid), MessageButtons.ContinueCancel) != DialogResult.OK)
                    return false;
            }
            return true;
        }

        private static string ContinueUploadMessage(ValidateDeckResult valid)
        {
            StringBuilder msg = new StringBuilder("The deck contains the following error");
            if ((valid & (valid - 1)) != 0)
                msg.Append("s");
            msg.Append(".\n\n");
            if ((valid & ValidateDeckResult.ContainsDuplicates) != 0)
                msg.Append("Duplicates; ");
            if ((valid & ValidateDeckResult.UnknownCard) != 0)
                msg.Append("Unknown cards; ");
            if ((valid & ValidateDeckResult.MaxInHandExceeded) != 0)
                msg.Append("Invalid amounts; ");
            if ((valid & ValidateDeckResult.LessThan60Cards) != 0)
                msg.Append("Less than 60 cards; ");
            msg.Remove(msg.Length - 2, 2);
            msg.Append(". \n\nContinue with upload?");
            return msg.ToString();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (string.IsNullOrEmpty(text))
                listBoxCardList.DataSource = _cards.GetAll();
            else
                listBoxCardList.DataSource = _cards.GetFuzzyMatches(text);
        }

        private void listBoxCardList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_deck == null)
                return;
            string cardName = (string)((ListBox)sender).SelectedItem;
            Card card = _cards.GetByName(cardName);
            if (richTextBoxDeck.Text.IndexOf(card.Name, StringComparison.InvariantCultureIgnoreCase) != -1)
            {
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            richTextBoxDeck.AppendText(card.InitialAmount.ToString() + " " + cardName + "\n");
            ValidateDeck();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (_client == null)
                Login();
        }

        private void Login()
        {
            FormLogin dlg = new FormLogin();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _client = dlg.Client;
                _userName = dlg.UserName;
                _cards = new Cards(dlg.CardDataFileName);
                _decks = new Decks(_deckPrefix, _client);
                listBoxCardList.DataSource = _cards.GetAll();
                Text = Text + " - " + dlg.WikiName;
            }
            else
            {
                Close();
            }
            UpdateUI(false);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_client != null)
            {
                _client.Dispose();
                _client = null;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormNewDeck dlg = new FormNewDeck(_client, _deckPrefix);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _deck = new Deck(dlg.DeckPage, dlg.DeckName);
                _deck.SetDefaultContent(dlg.DeckName, _userName);
                richTextBoxDeck.Text = _deck.Cards;
                textBoxDeckName.Text = dlg.DeckName;
                ValidateDeck();
            }
            UpdateUI(false);
        }

        private void UpdateUI(bool working)
        {
            buttonValidate.Enabled = _deck != null;
            buttonNew.Enabled = !working;
            buttonLoad.Enabled = !working;
            buttonUpload.Enabled = !working && _deck != null;
            buttonDecklist.Enabled = !working && _deck != null;
            richTextBoxDeck.Enabled = _deck != null;
            buttonView.Enabled = _deck != null;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            string url = _client.Site + "wiki/" + _deck.PageTitle;
            Process.Start(url);
        }

        private void buttonDecklist_Click(object sender, EventArgs e)
        {
            FormDecklists dlg = new FormDecklists(_client, _deck, _cards, _deckListsPageName, _userName);
            dlg.ShowDialog(this);
        }

        private DialogResult ShowMessage(string message, MessageButtons buttons = MessageButtons.OK)
        {
            FormMessage dlg = new FormMessage(message, buttons);
            return dlg.ShowDialog(this);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout dlg = new FormAbout();
            dlg.ShowDialog(this);
        }

        private void BlockedUser()
        {
            ShowMessage("You have been blocked from editing wiki pages.");
            Application.Exit();
        }

    }
}

