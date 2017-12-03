using System;
using System.Text;
using System.Security.Cryptography;


namespace WikiDeck
{
    internal static class Encryption
    {
        private static byte[] entropy = { 2, 212, 44, 78, 108, 63, 1, 2, 244, 33 };

        public static string Decrypt(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            byte[] unencrypted = ProtectedData.Unprotect(data, entropy, DataProtectionScope.CurrentUser);
            return Decode(unencrypted);
        }

        public static string Encrypt(string text)
        {
            byte[] data = Encode(text);
            byte[] encrypted = ProtectedData.Protect(data, entropy, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encrypted);
        }

        private static byte[] Encode(string data)
        {
            return Encoding.UTF8.GetBytes(data);
        }

        private static string Decode(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }


    }
}
