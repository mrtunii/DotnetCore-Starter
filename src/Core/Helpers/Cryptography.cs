using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SM.Core.Helpers
{
    public static class Cryptography
    {
        public static String ComputeSHA256(String text)
        {
            return ComputeSHA256(text, Encoding.Unicode);
        }

        private static String ComputeSHA256(String text, Encoding encoding)
        {
            var textBytes = encoding.GetBytes(text);
            return ComputeSHA256(textBytes);
        }

        private static String ComputeSHA256(byte[] bytes)
        {
            using (var hashAlgorithmImpl = SHA256.Create())
            {
                var hashBytes = hashAlgorithmImpl.ComputeHash(bytes);
                return String.Concat(hashBytes.Select(b => b.ToString("x2")));
            }
        }
    }
}
