using System.Windows.Forms;

namespace WikiDeck
{
    public partial class FormMessage : Form
    {
        public FormMessage(string message, MessageButtons buttons = MessageButtons.OK)
        {
            InitializeComponent();
            labelMessage.Text = message;
            SetButtons(buttons);
        }

        private void SetButtons(MessageButtons buttons)
        {
            if (buttons == MessageButtons.OK)
            {
                button1.Text = "OK";
                button1.DialogResult = DialogResult.OK;
                button2.Visible = false;
            }
            else if (buttons == MessageButtons.ContinueCancel)
            {
                button2.Text = "Continue";
                button2.DialogResult = DialogResult.OK;
                button1.Text = "Cancel";
                button1.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
