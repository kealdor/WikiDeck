using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikiaClientLibrary;

namespace WikiDeck
{
    public partial class FormDecklists : Form
    {
        private WikiaClient _client;
        private Decklists _decklists;
        private Deck _deck;
        private DecklistsEntry _entry;
        private Cards _cards;
        private string _userName;

        public FormDecklists(WikiaClient client, Deck deck, Cards cards, string decklistsPageTitle, string userName)
        {
            InitializeComponent();
            _client = client;
            _deck = deck;
            _cards = cards;
            _userName = userName;
            _decklists = new Decklists(_client, decklistsPageTitle);
        }

        private void FormDecklists_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.CancelAsync();
        }

        private async void FormDecklists_Shown(object sender, EventArgs e)
        {
            _entry = await _decklists.GetEntryAsync(_deck.DeckName);
            if (_entry == null)
            {
                labelStatus.Text = "This deck does not have a current entry in decklists.";
                _entry = new DecklistsEntry();
                _entry.Link = _deck.DeckName;
                textBoxTitle.Text = _deck.DeckName;
            }
            else
            {
                labelStatus.Text = "This deck already has a current entry in decklists.";
                textBoxTitle.Text = _entry.Name;
                textBoxDescription.Text = _entry.Description;
                comboBoxStrategy.Text = _entry.Strategy;
            }
        }

        private async void buttonOK_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Updating Decklists....";
            _entry.Name = textBoxTitle.Text;
            _entry.Strategy = comboBoxStrategy.Text;
            _entry.Description = textBoxDescription.Text;
            _entry.SetSets(_deck.GetSets(_cards));
            _entry.SetColors(_deck.GetColors(_cards));
            if (string.IsNullOrEmpty(_entry.Author))
            {
                _entry.Author = "[[User:" + _userName + "|" + _userName + "]]";
            }
            // TODO: error handling in buttonOK_Click
            await _decklists.Update(_entry);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
