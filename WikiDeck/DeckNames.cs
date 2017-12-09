using System.Text;
using System.Web;

namespace WikiDeck
{
    public static class DeckNames
    {
        public const int MaxDeckNameSize = 255;
        public const string InvalidCharacters = "&%:#<>[]|{}/~?+";

        public static string GetInvalidCharacters(string name)
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

        public static bool IsValidLength(string name)
        {
            string encodedName = HttpUtility.UrlEncode(name);
            int len = Encoding.UTF8.GetByteCount(encodedName);
            return len <= MaxDeckNameSize;
        }

        public static bool IsInvalidPath(string name)
        {
            return name == "." || name == "..";
        }

        public static bool HasTwoConsecutiveSpaces(string name)
        {
            int consecutiveSpaces = 0;
            foreach (char c in name)
            {
                if (c == ' ' || c == '_')
                {
                    if (++consecutiveSpaces > 1)
                        return true;
                }
                else
                {
                    consecutiveSpaces = 0;
                }
            }
            return false;
        }

        public static bool HasInvalidTerminators(string name)
        {
            return
                name[0] == ' ' ||
                name[0] == '_' ||
                name[name.Length - 1] == ' ' ||
                name[name.Length - 1] == '_';
        }
    }
}
