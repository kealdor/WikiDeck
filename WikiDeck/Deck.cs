﻿using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WikiaClientLibrary;

namespace WikiDeck
{
    public class Deck
    {
        private WikiaPage _deckPage;

        public string Cards { get; set; }

        public Deck(WikiaPage deckPage)
        {
            _deckPage = deckPage;
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
