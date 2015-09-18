using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeTwoFromPosition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.Write("Input an integer: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);

            Console.WriteLine(program.TakeTwoFromPosition(word, number));
            Console.ReadLine();
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            if (n > 2)
            {
                return str.Substring(0, 2);
            }

            return str.Substring(n, 2);
        }
    }
}
