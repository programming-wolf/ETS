using System;
using System.Collections.Generic;
using De.ProgrammingWolf.Business.Logic.core;

namespace De.ProgrammingWolf.Business.Logic
{
    public class MainLogic
    {
        public bool ExecuteTheLogic(byte[] array)
        {
            var convertedArray = new MainCoreClass().ConvertByteArrayToLong(array);
            bool retVal;
            if (convertedArray > 256)
            {
                Console.WriteLine("The value is more than a byte!");
                retVal = false;
            }
            else
            {
                retVal = true;
            }

            return retVal;
        }
    }
}
