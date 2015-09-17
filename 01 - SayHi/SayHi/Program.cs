using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Please input a name: ");
            string input = Console.ReadLine();

            Console.WriteLine(program.SayHi(input));
            Console.ReadLine();
        }
        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }
    }
}

