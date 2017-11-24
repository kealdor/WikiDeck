using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WikiDeck
{
    public class Decks : List<string>
    {
        public void Load(string site)
        {
            Clear();

            string apfrom = "";
            XmlDocument doc = new XmlDocument();
            string baseCommand = site + "api.php?action=query&list=allpages&apprefix=Decks/&aplimit=500&format=xml";

            using (WebClient client = new WebClient())
            {
                do
                {
                    string command = baseCommand;
                    if (!string.IsNullOrEmpty(apfrom))
                        command += "&apfrom=" + apfrom;
                    string contents = client.DownloadString(command);
                    doc.LoadXml(contents);
                    XmlNodeList deckNodes = doc.SelectNodes("/api/query/allpages/p");
                    foreach (XmlNode deckNode in deckNodes)
                    {
                        string title = deckNode.Attributes.GetNamedItem("title").Value;
                        string name = title.Substring("Decks/".Length);
                        Add(name);
                    }
                    XmlNode continueNode = doc.SelectSingleNode("/api/query-continue/allpages");
                    apfrom = continueNode == null ? "" : continueNode.Attributes.GetNamedItem("apfrom").Value;

                } while (!string.IsNullOrEmpty(apfrom));
            }
        }
    }
}
