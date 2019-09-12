using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetDelegateTest
{
    public class WriterFunc
    {
        public static void PrintNumber(int number)
        {
            Console.WriteLine($"PrintNumber:{number}");
        }

        public static void SquareFunction(int number)
        {
            Console.WriteLine($"SquareFunction:{Math.Pow(number,2)}");
        }

        public static void RadicalFunction(int number)
        {
            Console.WriteLine($"RadicalFunction:{Math.Sqrt(number)}");
        }

    }
}
