using System.Collections.Generic;

namespace WikiDeck
{
    public class SetInfo
    {
        private static Dictionary<string, string> nameMap = new Dictionary<string, string>()
        {
            {"D", "Starter" },
            {"ORI", "Origins" },
            {"BFZ", "Battle for Zendikar" },
            {"OGW", "Oath of the Gatewatch" },
            {"SOI", "Shadows over Innistrad" },
            {"EMN", "Eldritch Moon" },
            {"KLD", "Kaladesh" },
            {"AER", "Aether Revolt" },
            {"AKH", "Amonkhet" },
            {"XLN", "Ixalan" },
        };

        public SetInfo(string code)
        {
            Code = code;
        }

        public string Code { get; set; }
        public string Name
        {
            get
            {
                string name;
                if (nameMap.TryGetValue(Code, out name))
                    return name;
                return Code;
            }
        }

    }
}