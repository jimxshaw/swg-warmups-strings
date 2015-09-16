using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeTwoFromPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.Write("Input an integer: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);

            if (number > 2)
            {
                number = 0;
            }

            Console.WriteLine(TakeTwoFromPosition(word, number));
            Console.ReadLine();
        }

        public static string TakeTwoFromPosition(string str, int n)
        {
            return str.Substring(n, 2);
        }
    }
}
