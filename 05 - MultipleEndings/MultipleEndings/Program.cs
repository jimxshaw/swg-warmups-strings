using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleEndings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            Console.WriteLine(MultipleEndings(input));
            Console.ReadLine();
        }
        public static string MultipleEndings(string str)
        {
            return str.Substring(str.Length - 2) + str.Substring(str.Length - 2) + str.Substring(str.Length - 2);
        }
    }
}
