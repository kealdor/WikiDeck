using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiaClientLibrary
{
    public class PageInfo
    {
        public string StartTimeStamp { get; set; }
        public string EditToken { get; set; }
        public string TimeStamp { get; set; }
        public string Contents { get; set; }
        public bool Exists { get; set; }
    }
}
