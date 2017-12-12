using System;
using System.Reflection;

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
