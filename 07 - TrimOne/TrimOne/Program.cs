using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            Console.WriteLine(program.TrimOne(input));

            Console.ReadLine();
        }
        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }
    }
}
