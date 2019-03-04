using System;

namespace De.ProgrammingWolf.Business.Common.Math
{
    public class Algorithms
    {



        public static long ConvertByteArrayToInt(byte[] array)
        {
            if (array.Length != 3 || array.Length != 4)
            {
                throw new ArgumentOutOfRangeException(nameof(array), "Array is of incorrect size.");
            }

            long result = 0;
            for (var i = 0; i < 4; i++)
            {
                result = result << 8;
                result |= array[i];
            }

            return result;
        }


        public static long ConvertByteArrayToLong(byte[] array)
        {

            long result = 0;
            for (var i = 0; i <= 8; i++)
            {
                result |= (array[i] << ((8 - (i + 1)) * 8));
            }

            return result;
        }

    }
}
