using System;
using System.Drawing;
using System.Windows.Forms;
using WikiaClientLibrary;

namespace WikiDeck
{
    public partial class FormNewDeck : Form
    {
        WikiaClient _client;
        string _deckPrefix;

        public WikiaPage DeckPage { get; set; }
        public string DeckName { get; set; }

        public FormNewDeck(WikiaClient client, string deckPrefix)
        {
            InitializeComponent();
            _client = client;
            _deckPrefix = deckPrefix;
            labelStatus.Text = "";
        }

        private async void buttonOK_Click(object sender, EventArgs e)
        {
            labelStatus.ForeColor = SystemColors.ControlText;
            labelStatus.Text = "Checking name availability";
            UpdateUI(true);
            string name = _deckPrefix + textBoxDeckName.Text;
            WikiaPage page = new WikiaPage(_client, name);
            await page.LoadAsync();
            UpdateUI(false);
            if (page.Exists)
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "A deck with that name already exists.";
            }
            else
            {
                DeckPage = page;
                DeckName = textBoxDeckName.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void UpdateUI(bool checking)
        {
            textBoxDeckName.Enabled = !checking;
            buttonOK.Enabled = !checking;
        }

        private void FormNewDeck_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.CancelAsync();
        }
    }
}
