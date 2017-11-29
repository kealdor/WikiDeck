using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WikiaClientLibrary;

namespace WikiDeck
{
    public class Deck
    {
        private static char[] newLine = new char[] { '\n' };

        private WikiaPage _deckPage;
        private string _deckName;

        public string Cards { get; set; }
        public string PageTitle => _deckPage.PageTitle;
        public string DeckName => _deckName;
        
        public Deck(WikiaPage deckPage, string deckName)
        {
            _deckPage = deckPage;
            _deckName = deckName;
        }

        public List<string> GetSets(Cards cards)
        {
            List<string> sets = new List<string>();
            string[] names = Cards.Split(newLine);
            foreach (string name in names)
            {
                int spacePos = name.IndexOf(' ');
                Card card = cards.GetByName(name.Substring(spacePos+1));
                // Consider: throw exception if not found
                if (card != null && !(card.IsLand && card.SetCode == "D"))
                {
                    if (!sets.Contains(card.SetCode))
                        sets.Add(card.SetCode);
                }
            }
            return sets;
        }

        public List<string> GetColors(Cards cards)
        {
            List<string> colors = new List<string>();
            string[] names = Cards.Split(newLine);
            foreach (string name in names)
            {
                int spacePos = name.IndexOf(' ');
                Card card = cards.GetByName(name.Substring(spacePos + 1));
                // Consider: throw exception if not found
                if (card != null)
                {
                    if (card.Colors != null)
                    {
                        foreach (string color in card.Colors)
                        {
                            if (!colors.Contains(color))
                                colors.Add(color);
                        }
                    }
                }
            }
            return colors;
        }

        public void SetDefaultContent(string title, string author)
        {
            StringBuilder content = new StringBuilder("{{Deck|Name='''");
            content.Append(title);
            content.Append("'''");
            if (!string.IsNullOrEmpty(author))
            {
                content.Append(" by ");
                content.Append(author);
            }
            content.Append("\n|Deck=\n}}{{Clear}}{{DeckCharts}}{{SampleHand}}\n");
            Cards = "";
            _deckPage.Content = content.ToString();
        }

        public async Task LoadAsync()
        {
            await _deckPage.LoadAsync();
            Match match = Regex.Match(_deckPage.Content, @"{{Deck.*\|Deck=([^}]+)}}", RegexOptions.Singleline);
            if (match.Success)
                Cards = match.Groups[1].Value.Trim();
        }

        public async Task UploadAsync()
        {
            _deckPage.Content = Regex.Replace(
                _deckPage.Content, 
                @"({{Deck.*\|Deck=)([^}]+)(}}.*$)", 
                x => x.Groups[1] + "\n" + Cards + x.Groups[3],
                RegexOptions.Singleline
            );
            await _deckPage.SaveAsync("Uploaded via WikiDeck");
        }
    }
}
