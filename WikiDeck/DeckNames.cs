using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDeck
{
    public static class DeckNames
    {
        public const int MaxDeckNameSize = 255;
        public const string InvalidCharacters = "&%:#<>[]|{}/.~";

        public static string ValidateCharacters(string name)
        {
            string badChars = "";
            foreach (char c in name)
            {
                int pos = InvalidCharacters.IndexOf(c);
                if ( pos != -1)
                {
                    char badChar = InvalidCharacters[pos];
                    if (badChars.IndexOf(badChar) == -1)
                        badChars += badChar;
                }
            }
            return badChars;
        }
    }
}
