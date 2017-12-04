using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WikiDeck
{
    internal static class AppVersion
    {
        public static string GetVersion()
        {
            return GetVersion(Assembly.GetExecutingAssembly());
        }

        public static string GetVersion(Assembly assembly)
        {
            Version version = assembly.GetName().Version;
            return $"{version.Major}.{version.Minor}.{version.Build}.alpha";
        }
    }
}
