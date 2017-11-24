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
    public partial class FormCard : Form
    {
        public string CardName { get; set; }

        public FormCard()
        {
            InitializeComponent();
        }
    }
}
