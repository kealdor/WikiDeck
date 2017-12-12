using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WikiDeck
{
    public static class CardListExtentions
    {
        public static void Load(this List<Card> cards, string fileName)
        {
            List<Card> loadedCards = GetCardData(fileName);
            NormalizeOtherCards(loadedCards);
            cards.AddRange(loadedCards);
        }

        private static void NormalizeOtherCards(List<Card> cards)
        {
            List<Card> twoFacedCards = cards.Where(x => x.CardNumber.EndsWith("a")).ToList();
            foreach (Card card in twoFacedCards)
            {
                string otherCardNumber = card.CardNumber.Substring(0, card.CardNumber.Length - 1) + "b";
                Card otherCard = cards.Where(x => x.CardNumber == otherCardNumber).Single();
                card.OtherCard = otherCard;
                cards.Remove(otherCard);
            }
        }

        private static List<Card> GetCardData(string fileName)
        {
            string json = File.ReadAllText(fileName);
            List<Card> loadedCards = JsonConvert.DeserializeObject<List<Card>>(json);
            return loadedCards;
        }

        public static List<Card> FuzzyMatch(this IEnumerable<Card> cards, string match)
        {
            char[] chars = match.ToCharArray();
            IEnumerable<Card> results = cards.Where(x => Fuzzy(x.LowerCaseName, chars)).OrderBy(x => Weight(x.LowerCaseName, match));
            return results.ToList();
        }

        public static Card GetByName(this IEnumerable<Card> cards, string cardName)
        {
            string lowerCaseName = cardName.ToLowerInvariant();
            return cards.Where(x => x.LowerCaseName == lowerCaseName).FirstOrDefault();
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
    }
}
