using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHalf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Input a string of event length: ");
            string input = Console.ReadLine();

            Console.WriteLine(program.FirstHalf(input));

            Console.ReadLine();
        }
        public string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }
}
