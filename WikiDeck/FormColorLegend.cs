using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiDeck
{
    public partial class FormColorLegend : Form
    {
        public FormColorLegend(Dictionary<ValidateDeckResult, ColorInfo> colors)
        {
            InitializeComponent();
            SetEntry(labelValid, colors[ValidateDeckResult.Valid]);
            SetEntry(labelBadFormat, colors[ValidateDeckResult.BadFormat]);
            SetEntry(labelUnknownCard, colors[ValidateDeckResult.UnknownCard]);
            SetEntry(labelDuplicate, colors[ValidateDeckResult.ContainsDuplicates]);
            SetEntry(labelMaxExceeded, colors[ValidateDeckResult.MaxInHandExceeded]);
        }

        private void SetEntry(Label label, ColorInfo color)
        {
            label.Text += " (" + color.Name + ")";
            label.ForeColor = color.Color;
        }

        private void FormColorLegend_Load(object sender, EventArgs e)
        {
            if (Owner == null)
                return;
            Point startLocation = Owner.Location;
            startLocation.Offset(Owner.Size.Width, 80);
            Screen screen = Screen.FromControl(Owner);
            int screenWidth = screen.WorkingArea.Width;
            int overflow = screenWidth - (startLocation.X + Size.Width);
            if (overflow < 0)
                startLocation.X += overflow;
            Location = startLocation;
        }
    }
}
