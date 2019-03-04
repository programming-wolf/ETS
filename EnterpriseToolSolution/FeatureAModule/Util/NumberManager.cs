using System;

namespace De.ProgrammingWolf.Feature.A.Util
{
    public class NumberManager
    {
        public static long ConvertByteArrayToLong(byte[] array)
        {
            long result = BitConverter.ToInt64(array, 0);

            return result;
        }
    }
}
