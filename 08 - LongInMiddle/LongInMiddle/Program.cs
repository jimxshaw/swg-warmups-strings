using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongInMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string A: ");
            string inputA = Console.ReadLine();
            Console.Write("Input string B: ");
            string inputB = Console.ReadLine();
            Console.WriteLine(LongInMiddle(inputA, inputB));

            Console.ReadLine();
        }

        public static string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return b + a + b;
            }
            else
            {
                return a + b + a;
            }
        }
    }
}
