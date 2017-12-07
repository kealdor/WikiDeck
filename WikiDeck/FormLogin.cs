using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using WikiaClientLibrary;


namespace WikiDeck
{
    public partial class FormLogin : Form
    {
        private string _userAgent;

        private List<SiteInfo> _sites = new List<SiteInfo>()
        {
            new SiteInfo("Magic Duels", "http://magicduels.wikia.com", "DuelsCards.json", true),
            new SiteInfo("Magic Arena", "http://magicarena.wikia.com", "ArenaCards.json", false),
        };

        public WikiaClient Client { get; private set; }
        public string UserName { get; private set; }
        public SiteInfo Site { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            _userAgent = MakeUserAgentString();
            comboBoxSite.DataSource = _sites;
            comboBoxSite.DisplayMember = nameof(SiteInfo.Name);
            LoadDetails();
            labelStatus.Text = "";
            textBoxUsername.TextChanged += InputTextChanged;
            textBoxPassword.TextChanged += InputTextChanged;
            UpdateUI();
        }

        private async void buttonOK_Click(object sender, EventArgs e)
        {
            labelStatus.ForeColor = SystemColors.ControlText;
            labelStatus.Text = "Logging in...";

            SiteInfo site = (SiteInfo)comboBoxSite.SelectedItem;
    
            Client = new WikiaClient(site.Url, _userAgent);
            bool success = await Client.LoginAsync(textBoxUsername.Text, textBoxPassword.Text);
            if (success)
            {
                SaveDetails();
                DialogResult = DialogResult.OK;
                UserName = textBoxUsername.Text;
                Site = site;
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
            Properties.Settings.Default.Site = ((SiteInfo)(comboBoxSite.SelectedItem)).Url;
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
            string url = Properties.Settings.Default.Site;
            SiteInfo siteInfo = _sites.Where(x => x.Url == url).SingleOrDefault();
            if (siteInfo != null)
                comboBoxSite.SelectedItem = siteInfo;
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
                textBoxUsername.Text != "" &&
                textBoxPassword.Text != "";
            buttonOK.Enabled = okEnabled;
        }

        private string MakeUserAgentString()
        {
            string version = AppVersion.GetVersion();
            return $"WikiDeck/{version} (https://github.com/Aspallar/WikiDeck)";
        }
    }
}
