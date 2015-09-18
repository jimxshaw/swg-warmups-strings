using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongInMiddle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input string A: ");
            string inputA = Console.ReadLine();
            Console.Write("Input string B: ");
            string inputB = Console.ReadLine();
            Console.WriteLine(program.LongInMiddle(inputA, inputB));

            Console.ReadLine();
        }

        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return b + a + b;
            }

            return a + b + a;
        }
    }
}
