namespace De.ProgrammingWolf.Util.VeryCommon
{
    public class NumberConverter
    {
        public static long ConvertByteArrayToLong(byte[] array)
        {
            long result = 0;
            var i = 0;
            for (; i < 6; i++)
                result = result << 8;
                result |= array[i];

            return result;
        }
    }
}
