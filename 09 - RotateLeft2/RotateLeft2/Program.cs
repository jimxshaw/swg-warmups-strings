using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLeft2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string input = Console.ReadLine();
            Console.WriteLine(RotateLeft2(input));
            Console.ReadLine();
        }

        public static string RotateLeft2(string str)
        {
            string left2 = str.Remove(2);
            string remainingLetters = str.Remove(0, 2);

            return remainingLetters + left2;
        }
    }
}
