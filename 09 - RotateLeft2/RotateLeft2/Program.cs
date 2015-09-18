using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLeft2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a word: ");
            string input = Console.ReadLine();
            Console.WriteLine(program.RotateLeft2(input));
            Console.ReadLine();
        }

        public string RotateLeft2(string str)
        {
            if (str.Length == 2)
            {
                return str;
            }

            string left2 = str.Remove(2);
            string remainingLetters = str.Remove(0, 2);

            return remainingLetters + left2;
        }
    }
}
