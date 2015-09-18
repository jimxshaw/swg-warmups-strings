using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleEndings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            Console.WriteLine(program.MultipleEndings(input));
            Console.ReadLine();
        }
        public string MultipleEndings(string str)
        {
            return str.Substring(str.Length - 2) + str.Substring(str.Length - 2) + str.Substring(str.Length - 2);
        }
    }
}
