using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace WikiDeck
{
    public class Cards
    {
        private List<Card> _cards;

        public Cards()
        {
            _cards = GetData();
        }

        public Card GetByName(string cardName)
        {
            string lowerCaseName = cardName.ToLowerInvariant();
            return _cards.Where(x => x.LowerCaseName == lowerCaseName).FirstOrDefault();
        }

        public List<string> GetAll()
        {
            return _cards.Select(x => x.Name).OrderBy(x => x).ToList();
        }

        public List<string> GetFuzzyMatches(string match)
        {
            char[] chars = match.ToCharArray();
            var results = _cards.Where(x => Fuzzy(x.LowerCaseName, chars)).OrderBy(x => Weight(x.LowerCaseName, match)).Select(x => x.Name);
            return results.ToList();
        }

        private List<Card> GetData()
        {
            string json = File.ReadAllText(@"cards.json");
            return JsonConvert.DeserializeObject<List<Card>>(json);
        }

        private static int Weight(string s, string match)
        {
            if (s.StartsWith(match))
                return 0;
            if (s.IndexOf(match) != -1)
                return 1;
            int weight = 2;
            for (int k = match.Length - 1; k > 0; k--)
            {
                if (s.StartsWith(match.Substring(0, k)))
                    return weight;
                ++weight;
            }
            return weight;
        }

        private static bool Fuzzy(string s, char[] chars)
        {
            // conatins all chars, in order
            int charsindex = 0;
            int strindex = 0;
            while (strindex < s.Length)
            {
                if (Char.ToLowerInvariant(s[strindex]) == chars[charsindex])
                {
                    ++charsindex;
                    if (charsindex >= chars.Length)
                        return true;
                }
                ++strindex;
            }
            return false;
        }


    }
}
