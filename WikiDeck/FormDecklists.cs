using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WikiaClientLibrary;

namespace WikiDeck
{
    public partial class FormDecklists : Form
    {
        private const string colorlessCode  = "{{C}}";

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

            textBoxName.TextChanged += InputTextChanged;
            textBoxDescription.TextChanged += InputTextChanged;
            comboBoxStrategy.TextChanged += InputTextChanged;
        }

        private void FormDecklists_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.CancelAsync();
        }

        private async void FormDecklists_Shown(object sender, EventArgs e)
        {
            UpdateUI(true);
            try
            {
                _entry = await _decklists.GetEntryAsync(_deck.DeckName);
                if (_entry == null)
                {
                    SetStatus("This deck does not have an entry in decklists. It will be created.");
                    _entry = new DecklistsEntry();
                    _entry.Link = _deck.DeckName;
                    textBoxName.Text = _deck.DeckName;
                }
                else
                {
                    SetStatus("This deck already has an entry in decklists. It will be updated.");
                    textBoxName.Text = _entry.Name;
                    textBoxDescription.Text = _entry.Description;
                    comboBoxStrategy.Text = _entry.Strategy;
                    checkBoxIncludeColorless.Checked = _entry.Colors.IndexOf(colorlessCode) != -1;
                }
                UpdateUI(false);
            }
            catch (WebException)
            {
                ShowError("Network error while accessing Decklists.");
                DisableAllExceptCancel();
            }
        }

        private async void buttonOK_Click(object sender, EventArgs e)
        {
            SetStatus("Updating Decklists....");
            _entry.Name = textBoxName.Text;
            _entry.Strategy = comboBoxStrategy.Text;
            _entry.Description = textBoxDescription.Text;
            _entry.SetSets(_deck.GetSets(_cards));
            _entry.SetColors(_deck.GetColors(_cards));
            if (checkBoxIncludeColorless.Checked)
            {
                _entry.Colors += colorlessCode;
            }
            if (string.IsNullOrEmpty(_entry.Author))
            {
                _entry.Author = "[[User:" + _userName + "|" + _userName + "]]";
            }
            UpdateUI(true);
            try
            {
                await _decklists.Update(_entry);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (WikiaEditConflictException)
            {
                ShowError("Upate failed. Decklists is being edited by someone else.");
            }
            catch (WebException)
            {
                ShowError("Update failed. Network error.");
            }
            UpdateUI(false);
        }

        private void linkLabelColorless_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string msg = "The available card data does not contain enough information to determine if a card is genuinely colorless, ";
            msg += "so WikiDeck cannot to automatically add \"Colorles\" to the deck colors. ";
            msg += "Check this box if the deck contains genuinely colorless (not artifact) cards.";
            FormMessage dlg = new FormMessage(msg);
            dlg.ShowDialog(this);
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            UpdateUI(false);
        }

        private void ShowError(string message)
        {
            labelStatus.ForeColor = Color.Red;
            labelStatus.Text = message;
        }

        private void SetStatus(string message)
        {
            labelStatus.ForeColor = SystemColors.ControlText;
            labelStatus.Text = message;
        }

        private void DisableAllExceptCancel()
        {
            foreach (Control control in Controls)
            {
                if (control.Name != "buttonCancel" && control.Name != "labelStatus")
                    control.Enabled = false;
            }
        }

        private void UpdateUI(bool working)
        {
            textBoxName.Enabled = !working;
            textBoxDescription.Enabled = !working;
            comboBoxStrategy.Enabled = !working;
            checkBoxIncludeColorless.Enabled = !working;
            buttonOK.Enabled = !working;
            if (!working)
            {
                buttonOK.Enabled =
                    textBoxName.Text != "" &&
                    textBoxDescription.Text != "" &&
                    comboBoxStrategy.Text != "";
            }
        }
    }
}
