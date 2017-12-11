using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WikiDeck
{
    public partial class FormCard : Form
    {
        private Regex _manaRegex = new Regex(@"{{(\d+|[RGBUWCX])}}");
        private Card _card;

        public FormCard()
        {
            InitializeComponent();
        }

        public Card Card
        {
            get
            {
                return _card;
            }
            set
            {
                _card = value;
                UpdateDetails();
            }
        }

        private void UpdateDetails()
        {
            labelName.Text = _card.Name;
            labelCardText.Text = AdjustText(_card.Text);
            labelFlavorText.Text = AdjustText(_card.FlavorText);
            labelType.Text = _card.Type;
            labelPower.Text = PowerToughnessText(_card.Power, _card.Toughness, _card.Loyalty);
            CreateCostImages(_card.Manacost);
        }

        private void CreateCostImages(string manacost)
        {
            ClearManaCostFlowPanel();
            if (string.IsNullOrEmpty(manacost))
                return;
            MatchCollection matches = _manaRegex.Matches(manacost);
            for (int k = matches.Count - 1; k >= 0; k--)
            {
                PictureBox mana = CreateManaPictureBox(matches[k].Groups[1].Value);
                flowLayoutPanelManaCost.Controls.Add(mana);
            }
        }

        private PictureBox CreateManaPictureBox(string manaCode)
        {
            Bitmap image = ManaImages.GetImage(manaCode);
            PictureBox box = new PictureBox();
            box.Image = image;
            box.Margin = new Padding(3, 0, 0, 0);
            box.Size = new Size(15, 15);
            box.TabStop = false;
            return box;
        }

        private void ClearManaCostFlowPanel()
        {
            while (flowLayoutPanelManaCost.Controls.Count > 0)
            {
                Control control = flowLayoutPanelManaCost.Controls[0];
                flowLayoutPanelManaCost.Controls.RemoveAt(0);
                control.Dispose();
            }
        }

        private string PowerToughnessText(string power, string toughness, int? loyalty)
        {
            if (loyalty.HasValue)
                return loyalty.Value.ToString();
            if (string.IsNullOrEmpty(power))
                return "";
            return power + "/" + toughness;
        }

        private string AdjustText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            StringBuilder sb = new StringBuilder(text);
            sb.Replace("<br/>", "\n");
            sb.Replace("{{", "{");
            sb.Replace("}}", "}");
            return sb.ToString();
        }
    }
}
