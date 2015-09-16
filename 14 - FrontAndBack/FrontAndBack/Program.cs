using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAndBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.Write("Input an integer that's fewer than the length of your word: ");
            string numString = Console.ReadLine();
            int number = Int32.Parse(numString);

            Console.WriteLine(FrontAndBack(word, number));
            Console.ReadLine();
        }

        public static string FrontAndBack(string str, int n)
        {
            string front = str.Remove(n);
            string back = str.Remove(0, str.Length - n);

            return front + back;
        }
    }
}
