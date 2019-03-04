using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using De.ProgrammingWolf.Business.Common.Util;
using JetBrains.Annotations;

namespace De.ProgrammingWolf.Util.Helper
{
    [PublicAPI]
    public static class HashHelper
    {
        private static readonly SHA256 ENCODE_ENGINE = new SHA256Managed();

        public static string EncodeSha256(string randomString)
        {
            var hashedBytes = ENCODE_ENGINE.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            string hashedString = string.Empty;
            hashedString = hashedBytes.Aggregate(hashedString, (current, b) => $"{current}{b:x2}");

            return hashedString;
        }

        public static string EncodeSha256(byte[] bytes)
        {
            // might be useful in the future!

            return null;
        }

        public static string EncodeFileContent(string filepath)
        {
            return EncodeSha256(CopyMachine.ReadContentFromFile(new FileInfo(filepath)));
        }
    }
}
