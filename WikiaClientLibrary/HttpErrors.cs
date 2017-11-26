using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiaClientLibrary
{
    internal static class HttpErrors
    {
        public static bool Is404NotFoundError(string message)
        {
            return message.IndexOf("(404)") != -1;
        }
    }
}
