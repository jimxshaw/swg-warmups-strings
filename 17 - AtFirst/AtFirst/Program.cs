using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.WriteLine(AtFirst(word));

            Console.ReadLine();
        }

        public static string AtFirst(string str)
        {
            if (str.Length == 2)
            {
                return str;
            }

            if (str.Length < 2)
            {
                return str + "@";
            }

            return str.Remove(2);
        }
    }
}
