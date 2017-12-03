using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
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
            _cards = new Cards();
            listBoxCardList.DataSource = _cards.GetAll();
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
            ValidateDeckResult result = ValidateDeckResult.Valid;
            char[] sep = { '\n' };
            string[] cardLines = richTextBoxDeck.Text.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            richTextBoxDeck.Text = "";
            Regex cardEntry = new Regex(@"^(\d+)\s+(.+)$");
            foreach (string line in cardLines)
            {
                Match match = cardEntry.Match(line);
                if (!match.Success)
                {
                    richTextBoxDeck.AppendText(line, Color.Red);
                    richTextBoxDeck.AppendText("\n");
                    result = ValidateDeckResult.BadFormat;
                    continue;
                }

                Card card = _cards.GetByName(match.Groups[2].Value);
                if (card == null)
                {
                    richTextBoxDeck.AppendText(line, Color.Red);
                    richTextBoxDeck.AppendText("\n");
                    if (result == ValidateDeckResult.Valid)
                        result = ValidateDeckResult.UnknownCard;
                    continue;
                }

                string correctCaseLine = match.Groups[1].Value + " " + card.Name;
                richTextBoxDeck.AppendText(correctCaseLine, Color.Green);
                richTextBoxDeck.AppendText("\n");
            }
            return result;
        }

        private async void buttonUpload_Click(object sender, EventArgs e)
        {
            ValidateDeckResult valid = ValidateDeck();
            if (valid == ValidateDeckResult.BadFormat)
            {
                ShowMessage("The deck contains entries with an invalid format. Please correct them before uploading.");
                return;
            }
            else if (valid == ValidateDeckResult.UnknownCard)
            {
                if (ShowMessage(
                        "The deck contains unknown cards. Are you sure you wish to continue with the upload?",
                        MessageButtons.ContinueCancel) != DialogResult.OK)
                    return;
            }
            UpdateUI(true);
            _deck.Cards = richTextBoxDeck.Text;
            await _deck.UploadAsync();
            UpdateUI(false);
            ShowMessage("Deck has been uploaded.");
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
            richTextBoxDeck.AppendText("4 " + cardName + "\n");
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
                _decks = new Decks(_deckPrefix, _client);
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
    }
}

