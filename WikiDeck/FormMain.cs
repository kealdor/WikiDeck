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

namespace WikiDeck
{
    public partial class FormMain : Form
    {
        private Cards _cards;
        private Decks _decks;
        private Deck _deck;

        public FormMain(Decks decks)
        {
            InitializeComponent();
            _cards = new Cards();
            _decks = decks;
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            ValidateDeck();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            FormChooseDeck dlg = new FormChooseDeck(_decks);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Deck deck = new Deck("http://magicduels.wikia.com/", dlg.ChosenDeck);
                deck.Load();
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
            foreach (string line in cardLines)
            {
                Match match = Regex.Match(line, @"^(\d+)\s+(.+)$");
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

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            _deck.Cards = richTextBoxDeck.Text;
            _deck.Upload();
            MessageBox.Show("Nothing Uploaded. Uploading is not yet implemented.");
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
    }
}
