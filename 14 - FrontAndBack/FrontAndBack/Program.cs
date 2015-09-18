using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAndBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.Write("Input an integer that's fewer than the length of your word: ");
            string numString = Console.ReadLine();
            int number = Int32.Parse(numString);

            Console.WriteLine(program.FrontAndBack(word, number));
            Console.ReadLine();
        }

        public string FrontAndBack(string str, int n)
        {
            string front = str.Remove(n);
            string back = str.Remove(0, str.Length - n);

            return front + back;
        }
    }
}
