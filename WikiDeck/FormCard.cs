using System;
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
        private FormCard _otherCardView;
        private Point _otherCardViewLocation = new Point(int.MinValue, int.MinValue);

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
            if (_card.Type.Contains("Planeswalker"))
                labelPower.Text = LoyaltyText(_card.Loyalty);
            else
                labelPower.Text = PowerToughnessText(_card.Power, _card.Toughness);
            CreateCostImages(_card.Manacost);

            if (_card.OtherCard != null)
            {
                if (Visible)
                    ShowOtherCard(_card.OtherCard);
            }
            else
            {
                if (_otherCardView != null)
                {
                    _otherCardView.Close();
                    _otherCardView = null;
                }
            }
        }

        private void ShowOtherCard(Card otherCard)
        {
            if (_otherCardView != null)
            {
                _otherCardView.Card = otherCard;
                return;
            }
            _otherCardView = new FormCard();
            _otherCardView.FormClosed += OtherCardView_FormClosed;
            _otherCardView.Card = otherCard;
            _otherCardView.StartPosition = FormStartPosition.Manual;
            _otherCardView.Text = _otherCardView.Text + " (other card)";
            _otherCardView.Move += OtherCardView_Move;
            if (_otherCardViewLocation.X != int.MinValue)
            {
                _otherCardView.Location = _otherCardViewLocation;
            }
            else
            {
                Point location = Location;
                location.Offset(0, Height);
                Screen screen = Screen.FromControl(this);
                if (location.Y > screen.WorkingArea.Height - 100)
                    location.Y = screen.WorkingArea.Height - 100;
                _otherCardView.Location = location;
            }
            _otherCardView.Show(this);
        }

        private void OtherCardView_Move(object sender, EventArgs e)
        {
            _otherCardViewLocation = _otherCardView.Location;
        }

        private void OtherCardView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _otherCardView = null;
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

        private string LoyaltyText(int? loyalty)
        {
            return "Loyalty " + (loyalty.HasValue ? loyalty.Value.ToString() : "X");
        }

        private string PowerToughnessText(string power, string toughness)
        {
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

        private void FormCard_Shown(object sender, EventArgs e)
        {
            if (_card.OtherCard != null)
            {
                ShowOtherCard(_card.OtherCard);
            }
        }
    }
}
