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
            labelStatus.UseMnemonic = false;
        }

        private async void buttonOK_Click(object sender, EventArgs e)
        {
            labelStatus.ForeColor = SystemColors.ControlText;
            SetStatus("Checking name availability", false);
            UpdateUI(true);
            string name = _deckPrefix + textBoxDeckName.Text;
            WikiaPage page = new WikiaPage(_client, name);
            await page.LoadAsync();
            UpdateUI(false);
            if (page.Exists)
            {
                SetStatus("A deck with that name already exists.", true);
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


        private void textBoxDeckName_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxDeckName.Text;
            if (text == "")
            {
                SetStatus("");
                buttonOK.Enabled = false;
                return;
            }
            if (char.IsLower(text[0]))
            {
                int pos = textBoxDeckName.SelectionStart;
                textBoxDeckName.Text = char.ToUpper(text[0]) + text.Substring(1);
                textBoxDeckName.SelectionStart = pos;
            }
            if (!DeckNames.IsValidLength(text))
            {
                buttonOK.Enabled = false;
                SetStatus("Deck name is too long.", true);
                return;
            }
            if (DeckNames.HasInvalidTerminators(text))
            {
                buttonOK.Enabled = false;
                SetStatus("Deck names cannot start/end with a space or underscore.", true);
                return;
            }
            if (DeckNames.HasTwoConsecutiveSpaces(text))
            {
                buttonOK.Enabled = false;
                SetStatus("Deck names cannot contain two consecutive spaces or underscores.", true);
                return;
            }
            if (DeckNames.IsInvalidPath(text))
            {
                buttonOK.Enabled = false;
                SetStatus("Deck name must not be \".\" or \"..\"", true);
                return;
            }
            string badChars = DeckNames.GetInvalidCharacters(text);
            if (badChars != "")
            {
                buttonOK.Enabled = false;
                string plural = badChars.Length > 1 ? "s" : "";
                SetStatus($"Invalid character{plural} in name: {badChars}", true);
                return;
            }
            SetStatus("");
            buttonOK.Enabled = true;
        }


        private void SetStatus(string message, bool isError = false)
        {
            labelStatus.ForeColor = isError ? Color.Red : SystemColors.ControlText;
            labelStatus.Text = message;
        }
    }
}
