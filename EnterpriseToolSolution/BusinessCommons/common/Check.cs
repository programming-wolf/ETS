namespace De.ProgrammingWolf.Business.Common.Common
{
    public static class Check
    {
        public static long ConvertByteArrayToLong(byte[] array)
        {
            long result = 0;
            long shift = 0;
            if (array != null)
                for (var i = 0; i <= 8; i++)
                    shift = (array[i] << ((8 - (i + 1)) * 8));
                    result |= shift;

            return result;
        }
    }
}
