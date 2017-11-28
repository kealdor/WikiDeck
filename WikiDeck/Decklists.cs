using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WikiaClientLibrary;

namespace WikiDeck
{
    internal class Decklists
    {
        private WikiaClient _client;
        private string _decklistsPageTitle;
        private WikiaPage _page;

        public Decklists(WikiaClient client, string decklistsPageTitle)
        {
            _client = client;
            _decklistsPageTitle = decklistsPageTitle;
            _page = new WikiaPage(_client, _decklistsPageTitle);
        }

        public async Task<DecklistsEntry> GetEntryAsync(string pageTitle)
        {
            await _page.LoadAsync();
            Match match = Regex.Match(_page.Content, @"{{DecklistRow\s*\|link\s*=\s*" + pageTitle, RegexOptions.Singleline);
            if (!match.Success)
                return null;
            string entryText = ExtractEntry(_page.Content, match.Index);
            return new DecklistsEntry(entryText);
        }

        public async Task Update(DecklistsEntry entry)
        {
            int retries = 5;
            while (retries > 0)
            {
                try
                {
                    await _page.OpenAsync();
                    InsertOrReplaceEntry(entry);
                    await _page.SaveAsync("WikiDeck updated " + entry.Link);
                    retries = 0;
                }
                catch (WikiaEditConflictException)
                {
                    --retries;
                    if (retries == 0)
                        throw;
                    await Task.Delay(100);
                }
            } 
        }

        private void InsertOrReplaceEntry(DecklistsEntry entry)
        {
            Match match = Regex.Match(_page.Content, @"{{DecklistRow\s*\|link\s*=\s*" + entry.Link, RegexOptions.Singleline);
            if (match.Success)
            {
                int startPos = match.Index;
                int len = GetEntryLength(_page.Content, startPos);
                string start = _page.Content.Substring(0, startPos);
                string end = _page.Content.Substring(startPos + len);
                _page.Content = start + entry.ToString() + end;
            }
            else
            {
                int startPos = _page.Content.IndexOf("<!-- Add your deck info above here! -->");
                if (startPos == -1)
                    throw new DecklistsException("Insertion point not found.");
                string start = _page.Content.Substring(0, startPos - 1);
                string end = _page.Content.Substring(startPos);
                _page.Content = start + "\n" + entry.ToString() + "\n" + end;
            }
        }

        private string ExtractEntry(string text, int startIndex)
        {
            int len = GetEntryLength(text, startIndex);
            return text.Substring(startIndex, len);
        }

        private static int GetEntryLength(string text, int startIndex)
        {
            int braceCount = 1;
            int index = startIndex + 1;
            while (braceCount != 0 && index < text.Length)
            {
                if (text[index] == '{')
                    ++braceCount;
                else if (text[index] == '}')
                    --braceCount;
                ++index;
            }
            if (index >= text.Length)
                throw new DecklistsException("Unclosed deck entry.");
            return index - startIndex + 1;
        }
    }
}
