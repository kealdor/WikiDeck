using System;
using System.Collections.Generic;

namespace WikiDeck
{
    public class FilterChangedEventArgs : EventArgs
    {
        public IEnumerable<Card> Cards { get; private set; }

        public FilterChangedEventArgs(IEnumerable<Card> cards)
        {
            Cards = cards;
        }
    }
}
