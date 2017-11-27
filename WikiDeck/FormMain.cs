using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
                Deck deck = new Deck(new WikiaPage(_client, _deckPrefix + dlg.ChosenDeck));
                await deck.LoadAsync();
                _deck = deck;
                richTextBoxDeck.Text = deck.Cards;
                textBoxDeckName.Text = dlg.ChosenDeck;
                ValidateDeck();
                UpdateUI(false);
            }
        }

        private void ValidateDeck()
        {
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
                    continue;
                }

                Card card = _cards.GetByName(match.Groups[2].Value);
                if (card == null)
                {
                    richTextBoxDeck.AppendText(line, Color.Red);
                    richTextBoxDeck.AppendText("\n");
                    continue;
                }

                string correctCaseLine = match.Groups[1].Value + " " + card.Name;
                richTextBoxDeck.AppendText(correctCaseLine, Color.Green);
                richTextBoxDeck.AppendText("\n");
            }
        }

        private async void buttonUpload_Click(object sender, EventArgs e)
        {
            UpdateUI(true);
            _deck.Cards = richTextBoxDeck.Text;
            await _deck.UploadAsync();
            UpdateUI(false);
            MessageBox.Show("Deck has been uploaded.");
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
                _deck = new Deck(dlg.DeckPage);
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
            buttonLoad.Enabled = !working; ;
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
    }
}

