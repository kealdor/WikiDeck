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
    public partial class FormCardFilter : Form
    {
        public FormCardFilter()
        {
            InitializeComponent();
        }

        private void FormCardFilter_Load(object sender, EventArgs e)
        {
            if (Owner == null)
                return;
            Point startLocation = Owner.Location;
            startLocation.Offset(-Width, 80);
            if (startLocation.X < 0)
                startLocation.X = 0;
            Location = startLocation;
        }
    }
}
