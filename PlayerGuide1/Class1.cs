using System;

namespace PlayerGuide1
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            var convertedNumber = 0;

            for (int i = 0; i < BinaryArray.Length; i++)
            {
                convertedNumber += BinaryArray[BinaryArray.Length - i - 1] * (int)Math.Pow(2, i);
            }
            Console.WriteLine(convertedNumber);
            return convertedNumber;
            
        }
    }
}
