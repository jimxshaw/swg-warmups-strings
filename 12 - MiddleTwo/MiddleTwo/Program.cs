using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a word of even length: ");
            string word = Console.ReadLine();

            if (word.Length%2 == 0)
            {
                Console.WriteLine(program.MiddleTwo(word));
            }
            else
            {
                Console.WriteLine("Invalid. Your word is not of even length.");
            }
            Console.ReadLine();
        }

        public string MiddleTwo(string str)
        {
            return str.Substring((str.Length / 2) - 1, 2);
        }
    }
}
