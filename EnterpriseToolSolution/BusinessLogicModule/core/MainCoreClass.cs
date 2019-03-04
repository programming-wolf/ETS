using System;

namespace De.ProgrammingWolf.Business.Logic.core
{
    using System.IO;

    public sealed class MainCoreClass
    {


        public void DoMagic()
        {
            // magic core logic
            // lots
            // of
            // magic
            var content = GetFileContent(string.Empty);
            Console.WriteLine(content.ToString());

        }


        private byte[] GetFileContent(string filename)
        {
            if (filename == string.Empty)
                return null;

            return File.ReadAllBytes(filename);
        }


        internal long ConvertByteArrayToLong(byte[] array)
        {

            long result = 0;
            for (int i = 0; i < 6; i++)
            {
                result = result << 8;
                result |= array[i];
            }

            return result;
        }
    }
}
