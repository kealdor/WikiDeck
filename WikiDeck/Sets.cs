using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDeck
{
    public class Sets : List<SetInfo>
    {
        public Sets(IEnumerable<Card> cards)
        {
            List<string> setCodes = cards.Select(x => x.SetCode).Distinct().ToList();
            List<SetInfo> sets = new List<SetInfo>();
            foreach (string set in setCodes)
                sets.Add(new SetInfo(set));
            List<SetInfo> orderedSets = sets.OrderBy(x => x.Name).ToList();
            foreach (SetInfo set in orderedSets)
                Add(set);
        }
    }
}
