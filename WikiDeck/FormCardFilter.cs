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

        public FormCardFilter(IEnumerable<Card> cards, Sets sets)
        {
            InitializeComponent();
            _cards = cards;
            listBoxSets.DataSource = sets;
            listBoxSets.DisplayMember = "Name";
            listBoxSets.SelectedItem = null;
            WireEvents();
            UpdateUI();
        }

        private void WireEvents()
        {
            foreach (Control control in flowLayoutPanelColors.Controls)
                ((CheckBox)control).CheckedChanged += FilterCriteriaChanged;
            foreach (Control control in flowLayoutPanelTypes.Controls)
                ((CheckBox)control).CheckedChanged += FilterCriteriaChanged;
            listBoxSets.SelectedIndexChanged += FilterCriteriaChanged;
        }

        private void FormCardFilter_Load(object sender, EventArgs e)
        {
            if (Owner == null)
                return;
            Point startLocation = Owner.Location;
            startLocation.Offset(-Width, 48);
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

        private void UpdateUI()
        {
            bool cmcChecked = checkBoxUseCmc.Checked;
            numericUpDownCmcMin.Enabled = cmcChecked;
            numericUpDownCmcMax.Enabled = cmcChecked;
        }

        private List<string> GetColorList()
        {
            return GetCheckboxTagList(flowLayoutPanelColors);
        }

        private List<string> GetTypesList()
        {
            return GetCheckboxTagList(flowLayoutPanelTypes);
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
            if (checkBoxColorless.Checked)
            {
                if (colors.Count > 0)
                    result = result.Where(x => x.Colors == null || x.Colors.Intersect(colors).Any());
                else
                    result = result.Where(x => x.Colors == null);
            }
            else
            {
                if (colors.Count > 0)
                    result = result.Where(x => x.Colors != null && (x.Colors.Intersect(colors).Any()));
            }

            List<string> types = GetTypesList();
            if (types.Count > 0)
                result = result.Where(x => x.Types.Intersect(types).Any());

            if (checkBoxUseCmc.Checked)
            {
                int max = (int)numericUpDownCmcMax.Value;
                int min = (int)numericUpDownCmcMin.Value;
                if (max == min)
                {
                    result = result.Where(x => x.Cmc == min);
                }
                else
                {
                    result = result.Where(x => x.Cmc >= min && x.Cmc <= max);
                }
            }

            if (listBoxSets.SelectedItems.Count == 1)
            {
                string setCode = ((SetInfo)listBoxSets.SelectedItems[0]).Code;
                result = result.Where(x => x.SetCode == setCode);
            }
            else if (listBoxSets.SelectedItems.Count > 1)
            {
                List<string> setCodes = new List<string>();
                foreach (object set in listBoxSets.SelectedItems)
                    setCodes.Add(((SetInfo)set).Code);
                result = result.Where(x => setCodes.Contains(x.SetCode));
            }

            return result;
        }

        public event EventHandler<FilterChangesEventArgs> FilterChanged;
        protected virtual void OnFilterChanged(IEnumerable<Card> filteredCards)
        {
            var handler = FilterChanged;
            handler?.Invoke(this, new FilterChangesEventArgs(filteredCards));
        }

        private void checkBoxUseCmc_CheckStateChanged(object sender, EventArgs e)
        {
            UpdateUI();
            FilterCriteriaChanged(sender, e);
        }

        private void numericUpDownCmcMin_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownCmcMax.Value < numericUpDownCmcMin.Value)
                numericUpDownCmcMax.Value = numericUpDownCmcMin.Value;
            FilterCriteriaChanged(sender, e);
        }

        private void numericUpDownCmcMax_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownCmcMin.Value > numericUpDownCmcMax.Value)
                numericUpDownCmcMin.Value = numericUpDownCmcMax.Value;
            FilterCriteriaChanged(sender, e);
        }
    }
}
