using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDeck
{
    public class FilterChangesEventArgs : EventArgs
    {
        public IEnumerable<Card> Cards { get; private set; }

        public FilterChangesEventArgs(IEnumerable<Card> cards)
        {
            Cards = cards;
        }
    }
}
