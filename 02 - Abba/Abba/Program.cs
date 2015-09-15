using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string a: ");
            string inputA = Console.ReadLine();
            Console.Write("Input string b: ");
            string inputB = Console.ReadLine();

            Console.WriteLine(Abba(inputA, inputB));

            Console.ReadLine();
        }
        public static string Abba(string a, string b)
        {
            return a + b + b + a;
        }
    }
}
