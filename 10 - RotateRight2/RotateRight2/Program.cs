using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateRight2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a word: ");
            string input = Console.ReadLine();

            if (input.Length < 2)
            {
                Console.WriteLine("Your word must be at least 2 letters");
            }
            else
            {
                Console.WriteLine(program.RotateRight2(input));
            }
            Console.ReadLine();
        }

        public string RotateRight2(string str)
        {
            if (str.Length == 2)
            {
                return str;
            }

            string right2 = str.Remove(0, str.Length - 2);
            string remainingLetters = str.Remove(str.Length - 2);

            return right2 + remainingLetters;
        }
    }
}
