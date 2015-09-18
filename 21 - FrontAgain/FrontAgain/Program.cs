using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAgain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Input a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(program.FrontAgain(word));
            Console.ReadLine();
        }

        public bool FrontAgain(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            if (str.Length == 2)
            {
                return true;
            }
            if (str.Substring(0, 2) == str.Substring(str.Length - 2))
            {
                return true;
            }

            return false;
        }
    }
}
