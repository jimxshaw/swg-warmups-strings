using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateRight2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string input = Console.ReadLine();

            if (input.Length < 2)
            {
                Console.WriteLine("Your word must be at least 2 letters");
            }
            else
            {
                Console.WriteLine(RotateRight2(input));
            }
            Console.ReadLine();
        }

        public static string RotateRight2(string str)
        {
            string right2 = str.Remove(0, str.Length - 2);
            string remainingLetters = str.Remove(str.Length - 2);

            return right2 + remainingLetters;
        }
    }
}
