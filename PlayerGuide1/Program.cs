using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PlayerGuide1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Test1 = { 0, 0, 0, 0 };
            int[] Test2 = { 1, 1, 1, 1 };
            int[] Test3 = { 0, 1, 1, 0 };
            int[] Test4 = { 0, 1, 0, 1 };

            
                Console.WriteLine(Equals(0, Kata.binaryArrayToNumber(Test1)));
                Console.WriteLine(Equals(15, Kata.binaryArrayToNumber(Test2)));
                Console.WriteLine(Equals(6, Kata.binaryArrayToNumber(Test3)));
                Console.WriteLine(Equals(5, Kata.binaryArrayToNumber(Test4)));
                Console.ReadKey();
        }
        

    }   
}
