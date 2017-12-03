using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiDeck
{
    public partial class FormChooseDeck : Form
    {
        private Decks _decks;

        public string ChosenDeck { get; private set; }

        public FormChooseDeck(Decks decks)
        {
            InitializeComponent();
            _decks = decks;
            listBoxDecks.DataSource = _decks;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ChosenDeck = (string)listBoxDecks.SelectedItem;
        }

        private void listBoxDecks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChosenDeck = (string)listBoxDecks.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await LoadDecks();
        }

        private async Task LoadDecks()
        {
            listBoxDecks.DataSource = null;
            UpdateUI(true);
            try
            {
                await _decks.LoadAsync();
            }
            catch (WebException)
            {
                WarnUserOfError();
            }
            listBoxDecks.DataSource = _decks;
            UpdateUI(false);
        }

        private void WarnUserOfError()
        {
            FormMessage dlg = new FormMessage("There was a network error while downloading decks. The list of decks may be empty or incomplete.");
            dlg.ShowDialog(this);
        }

        private void UpdateUI(bool loading)
        {
            buttonOk.Enabled = !loading && _decks.Count > 0;
            buttonRefresh.Enabled = !loading;
            if (loading)
            {
                listBoxDecks.MouseDoubleClick -= listBoxDecks_MouseDoubleClick;
            }
            else
            {
                listBoxDecks.MouseDoubleClick += listBoxDecks_MouseDoubleClick;
            }
        }

        private void FormChooseDeck_FormClosing(object sender, FormClosingEventArgs e)
        {
            _decks.CancelLoad();
        }

        private async void FormChooseDeck_Shown(object sender, EventArgs e)
        {
            if (_decks.Count == 0)
                await LoadDecks();
        }
    }
}
