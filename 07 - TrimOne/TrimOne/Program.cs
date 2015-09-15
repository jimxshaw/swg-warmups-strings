using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            Console.WriteLine(TrimOne(input));

            Console.ReadLine();
        }
        public static string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }
    }
}
