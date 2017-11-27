using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public FormMain(string deckPrefix)
        {
            InitializeComponent();
            _deckPrefix = deckPrefix;
            _cards = new Cards();
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
            // TODO: remove this guard once UpdateUI implemented
            if (_deck == null)
                return;
            _deck.Cards = richTextBoxDeck.Text;
            await _deck.UploadAsync();
            MessageBox.Show("Deck has been uploaded.");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (string.IsNullOrEmpty(text))
                listBoxCardList.DataSource = null;
            else
                listBoxCardList.DataSource = _cards.GetFuzzyMatches(text);
        }

        private void listBoxCardList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
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
                _decks = new Decks(_deckPrefix, _client);
            }
            UpdateUI();
        }

        private void UpdateUI()
        {
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_client != null)
            {
                _client.Dispose();
                _client = null;
            }
        }
    }
}

