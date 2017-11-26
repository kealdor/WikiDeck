using System;
using System.Drawing;
using System.Windows.Forms;
using WikiaClientLibrary;

namespace WikiDeck
{
    public partial class FormLogin : Form
    {
        public WikiaClient Client { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            LoadDetails();
            labelStatus.Text = "";
            textBoxSite.TextChanged += InputTextChanged;
            textBoxUsername.TextChanged += InputTextChanged;
            textBoxPassword.TextChanged += InputTextChanged;
            UpdateUI();
        }

        private async void buttonOK_Click(object sender, EventArgs e)
        {
            labelStatus.ForeColor = SystemColors.ControlText;
            labelStatus.Text = "Logging in...";
    
            Client = new WikiaClient(textBoxSite.Text);
            bool success = await Client.LoginAsync(textBoxUsername.Text, textBoxPassword.Text);
            if (success)
            {
                SaveDetails();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Login Failed";
                Client.Dispose();
                Client = null;
            }
        }

        private void SaveDetails()
        {
            Properties.Settings.Default.RememberPassword = checkBoxRememberPassword.Checked;
            Properties.Settings.Default.Site = textBoxSite.Text;
            Properties.Settings.Default.Username = textBoxUsername.Text;
            if (checkBoxRememberPassword.Checked)
                Properties.Settings.Default.Password = Encryption.Encrypt(textBoxPassword.Text);
            else
                Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();
        }

        private void LoadDetails()
        {
            checkBoxRememberPassword.Checked = Properties.Settings.Default.RememberPassword;
            textBoxSite.Text = Properties.Settings.Default.Site;
            textBoxUsername.Text = Properties.Settings.Default.Username;
            string password = Properties.Settings.Default.Password;
            if (!string.IsNullOrEmpty(password))
                textBoxPassword.Text = Encryption.Decrypt(password);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK && Client != null)
            {
                Client.Dispose();
                Client = null;
            }
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            bool okEnabled =
                textBoxSite.Text != "" &&
                textBoxUsername.Text != "" &&
                textBoxPassword.Text != "";
            if (okEnabled)
            {
                string site = textBoxSite.Text;
                okEnabled = site.StartsWith("http") &&
                    site.IndexOf("?") == -1 &&
                    Uri.IsWellFormedUriString(site, UriKind.Absolute);
            }
            buttonOK.Enabled = okEnabled;
        }

    }
}
