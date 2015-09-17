using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(FrontAgain(word));
            Console.ReadLine();
        }

        public static bool FrontAgain(string str)
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
