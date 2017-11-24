using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDeck
{
    class Card
    {
        private string _name;

        [JsonProperty(Required = Required.Always)]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                LowerCaseName = _name.ToLowerInvariant();
            }
        }

        public string Type { get; set; }

        public List<Ruling> Rulings { get; set; }

        public string Manacost { get; set; }

        public string Text { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        public string Rarity { get; set; }

        public string SetCode { get; set; }

        public string CardNumber { get; set; }

        public string Artist { get; set; }

        public List<string> Colors { get; set; }

        public int MultiverseID { get; set; }

        [JsonProperty(Required = Required.Always)]
        public List<string> Types { get; set; }

        public List<string> SubTypes { get; set; }

        public string Toughness { get; set; }

        public string Power { get; set; }

        public List<string> Names { get; set; }

        [JsonProperty("Flavor")]
        public string FlavorText { get; set; }

        public int? Loyalty { get; set; }

        public List<string> SuperTypes { get; set; }

        public string Watermark { get; set; }

        public string LowerCaseName { get; private set; }
    }
}
