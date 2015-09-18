using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapLast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Input a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(program.SwapLast(word));
            Console.ReadLine();
        }

        public string SwapLast(string str)
        {
            if (str.Length < 2)
            {
                return "Insufficient word length.";
            }
            if (str.Length == 2)
            {
                return str.Substring(1) + str.Substring(0, 1);
            }
            string sub = str.Remove(str.Length - 2);
            string subA = str.Substring(str.Length - 2, 1);
            string subB = str.Substring(str.Length - 1);

            return sub + subB + subA;
        }
    }
}
