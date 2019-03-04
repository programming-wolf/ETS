using System.IO;

namespace De.ProgrammingWolf.Feature.B.helper
{
    public static class Helper
    {
        internal static byte[] ReadBytes(string filename)
        {
            if (filename == null)
                return new byte[0];
            return File.ReadAllBytes(filename);
        }
    }
}
