using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a name: ");
            string input = Console.ReadLine();
            Console.WriteLine(SayHi(input));
            Console.ReadLine();
        }
        public static string SayHi(string name)
        {
            return "Hello " + name + "!";
        }
    }
}
