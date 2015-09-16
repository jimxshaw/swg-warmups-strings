using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string containing the word 'bad': ");
            string word = Console.ReadLine();
            Console.WriteLine(HasBad(word));

            Console.ReadLine();
        }

        public static bool HasBad(string str)
        {
            if (!str.Contains("bad"))
            {
                return false;
            }

            if (str.IndexOf("b") == 0 || str.IndexOf("b") == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
