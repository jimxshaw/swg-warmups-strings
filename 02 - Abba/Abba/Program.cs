using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input string a: ");
            string inputA = Console.ReadLine();
            Console.Write("Input string b: ");
            string inputB = Console.ReadLine();

            Console.WriteLine(program.Abba(inputA, inputB));

            Console.ReadLine();
        }
        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }
    }
}
