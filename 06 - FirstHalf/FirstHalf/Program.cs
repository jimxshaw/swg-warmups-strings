using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string of event length: ");
            string input = Console.ReadLine();

            Console.WriteLine(FirstHalf(input));

            Console.ReadLine();
        }
        public static string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }
}
