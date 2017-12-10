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
        private IEnumerable<Card> _cards;

        public FormCardFilter(IEnumerable<Card> cards)
        {
            InitializeComponent();
            _cards = cards;
            WireEvents();
        }

        private void WireEvents()
        {
            foreach (Control control in flowLayoutPanelColors.Controls)
                ((CheckBox)control).CheckedChanged += FilterCriteriaChanged;
            foreach (Control control in flowLayoutPanelTypes.Controls)
                ((CheckBox)control).CheckedChanged += FilterCriteriaChanged;
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

        private List<string> GetCheckboxTagList(Control container)
        {
            List<string> list = new List<string>();
            foreach (Control control in container.Controls)
            {
                if (control.Tag != null && ((CheckBox)control).Checked)
                {
                    list.Add((string)control.Tag);
                }
            }
            return list;
        }

        private List<string> GetColorList()
        {
            return GetCheckboxTagList(flowLayoutPanelColors);
        }

        private List<string> GetTypesList()
        {
            return GetCheckboxTagList(flowLayoutPanelTypes);
        }

        void GetFilter()
        {
            Cards cards = new Cards("DuelsCards.json");

            var filter = cards.Where(x => x.Colors != null && (x.Colors.Contains("Red") || x.Colors.Contains("Green")));

            var result = filter.ToList();

            int a = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cards cards = new Cards("DuelsCards.json");

            List<string> colors = GetColorList();

            var filter = cards.Where(x => x.Colors != null && (x.Colors.Contains("Red") || x.Colors.Contains("Green")));

            var filter2 = cards.Where(x => x.Colors != null && (x.Colors.Intersect(colors).Any()));

            var result = filter.ToList();

            var result2 = filter2.ToList();

            int a = 1;
        }

        private void FilterCriteriaChanged(object sender, EventArgs e)
        {
            IEnumerable<Card> cards = GetFilteredCards();
            OnFilterChanged(cards);
        }

        private IEnumerable<Card> GetFilteredCards()
        {
            IEnumerable<Card> result = _cards;

            List<string> colors = GetColorList();
            if (colors.Count > 0)
                result = result.Where(x => x.Colors != null && (x.Colors.Intersect(colors).Any()));

            List<string> types = GetTypesList();
            if (types.Count > 0)
                result = result.Where(x => x.Types.Intersect(types).Any());

            return result;
        }

        public event EventHandler<FilterChangesEventArgs> FilterChanged;
        protected virtual void OnFilterChanged(IEnumerable<Card> filteredCards)
        {
            var handler = FilterChanged;
            handler?.Invoke(this, new FilterChangesEventArgs(filteredCards));
        }
    }
}
