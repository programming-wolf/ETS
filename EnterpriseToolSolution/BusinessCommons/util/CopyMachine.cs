namespace De.ProgrammingWolf.Business.Common.Util
{
    using System.IO;

    public class CopyMachine
    {
        public static byte[] ReadContentFromFile(FileInfo file)
        {
            if (file != null)
                return File.ReadAllBytes(file.FullName);

            return null;
        }
    }
}
