using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace WikiDeck
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            InitializeText();
        }

        private void InitializeText()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            labelVersion.Text = "Version " + AppVersion.GetVersion(assembly);
            labelCopyright.Text = GetCopyright(assembly);
        }

        private string GetCopyright(Assembly assembly)
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (attributes.Length == 0)
                return "";
            return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }

        private void linkLabelDuels_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://magicduels.wikia.com");
        }

        private void linkLabelArena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://magicarena.wikia.com");
        }

        private void linkLabelSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Aspallar/WikiDeck");
        }
    }
}
