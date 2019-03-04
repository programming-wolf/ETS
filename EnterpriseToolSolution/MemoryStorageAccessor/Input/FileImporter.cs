using System.IO;

namespace De.ProgrammingWolf.MemoryStorage.Input
{
    internal static class FileImporter
    {

        internal static byte[] ReadFileForMemory(string filename)
        {
            if (filename == null)
                return null;
            return File.ReadAllBytes(filename);
        }

    }
}
