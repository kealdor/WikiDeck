using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WikiDeck
{
    public class DecklistsEntry
    {
        public const string exceptionMessage = "Invalid DecklistsEntry format. ";

        private static Dictionary<string, string> colorMap = new Dictionary<string, string>()
        {
            {"Red", "{{R}}"},
            {"Green", "{{G}}"},
            {"Blue", "{{U}}"},
            {"Black", "{{B}}"},
            {"White", "{{W}}"},
        };

        public string Link { get; set; }
        public string Strategy { get; set; }
        public string Colors { get; set; }
        public string Sets { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public DecklistsEntry()
        {
        }

        public DecklistsEntry(string text)
        {
            Parse(text);
        }

        public void Parse(string text)
        {
            text = text.Trim();
            if (!text.StartsWith("{{") && !text.EndsWith("}}"))
                throw new DecklistsException(exceptionMessage + "No enclosing braces");
            text = text.Substring(0, text.Length - 2);
            Link = GetItem(text, "link");
            Strategy = GetItem(text, "strategy");
            Colors = GetItem(text, "colors");
            Sets = GetItem(text, "sets");
            Author = GetItem(text, "author");
            Description = GetItem(text, "desc");
            Name = GetItem(text, "name");
        }

        public void SetColors(List<string> colors)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string color in colors)
                sb.Append(colorMap[color]);
            Colors = sb.ToString();
        }

        public void SetSets(List<string> sets)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string set in sets)
            {
                sb.Append("{{");
                sb.Append(set);
                sb.Append("C}}");
            }
            Sets = sb.ToString();
        }

        private string GetItem(string text, string entry)
        {
            string pattern = @"^\|" + entry + @"\s*=\s*(.*)";
            Match match = Regex.Match(text, pattern, RegexOptions.Multiline);
            if (!match.Success)
                throw new DecklistsException(exceptionMessage + "Bad entry for " + entry);
            return match.Groups[1].Value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("{{DecklistRow\n|link=");
            sb.Append(Link);
            sb.Append('\n');

            sb.Append("|strategy=");
            sb.Append(Strategy);
            sb.Append('\n');

            sb.Append("|colors=");
            sb.Append(Colors);
            sb.Append('\n');

            sb.Append("|sets=");
            sb.Append(Sets);
            sb.Append('\n');

            sb.Append("|author=");
            sb.Append(Author);
            sb.Append('\n');

            sb.Append("|desc=");
            sb.Append(Description);
            sb.Append('\n');

            sb.Append("|name=");
            sb.Append(Name);
            sb.Append("}}\n");

            return sb.ToString();
        }

    }

}