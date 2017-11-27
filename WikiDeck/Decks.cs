using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using WikiaClientLibrary;

namespace WikiDeck
{
    public class Decks : List<string>
    {
        private string _deckPrefix;
        private WikiaClient _client;

        public Decks(string deckPrefix, WikiaClient client)
        {
            _deckPrefix = deckPrefix;
            _client = client;
        }

        public async Task LoadAsync()
        {
            Clear();

            int prefixLength = _deckPrefix.Length;
            string apfrom = "";
            XmlDocument doc = new XmlDocument();
            string baseQuery = "&list=allpages&aplimit=500&format=xml&apprefix=" + _deckPrefix;

            do
            {
                string query = baseQuery;
                if (!string.IsNullOrEmpty(apfrom))
                    query += "&apfrom=" + apfrom;
                string contents = await _client.QueryAsync(query);
                doc.LoadXml(contents);
                XmlNodeList deckNodes = doc.SelectNodes("/api/query/allpages/p");
                foreach (XmlNode deckNode in deckNodes)
                {
                    string title = deckNode.Attributes.GetNamedItem("title").Value;
                    string name = title.Substring(prefixLength);
                    Add(name);
                }
                XmlNode continueNode = doc.SelectSingleNode("/api/query-continue/allpages");
                apfrom = continueNode == null ? "" : continueNode.Attributes.GetNamedItem("apfrom").Value;
            } while (!string.IsNullOrEmpty(apfrom));
        }

        public void CancelLoad()
        {
            _client.CancelAsync();
        }
    }
}
