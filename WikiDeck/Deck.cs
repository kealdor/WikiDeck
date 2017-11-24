using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WikiDeck
{
    public class Deck
    {
        private string _content;
        private string _name;
        private string _site;

        public string Cards { get; set; }

        public Deck(string site, string name)
        {
            _site = site;
            _name = name;
        }

        public async Task LoadAsync()
        {
            using (WebClient client = new WebClient())
            {
                _content = await client.DownloadStringTaskAsync(_site + "index.php?action=raw&title=Decks/" + _name);
                Match match = Regex.Match(_content, @"{{Deck.*\|Deck=([^}]+)}}", RegexOptions.Singleline);
                if (match.Success)
                    Cards = match.Groups[1].Value.Trim();
            }
        }

        public void Upload()
        {
            _content = Regex.Replace(
                _content, 
                @"({{Deck.*\|Deck=)([^}]+)(}}.*$)", 
                x => x.Groups[1] + "\n" + Cards + x.Groups[3],
                RegexOptions.Singleline
            );
        }
    }
}
