using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerGuide1
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            var bitNumber = 0;

            for (int i = 0; i < BinaryArray.Length; i++)
            {
                bitNumber += BinaryArray[BinaryArray.Length - i - 1] * (int)Math.Pow(2, i);
            }
            Console.WriteLine(bitNumber);
            return bitNumber;
            
        }
    }
}
