using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.WriteLine(program.AtFirst(word));

            Console.ReadLine();
        }

        public string AtFirst(string str)
        {
            if (str.Length == 2)
            {
                return str;
            }

            if (str.Length < 2)
            {
                return str + "@";
            }

            return str.Remove(2);
        }
    }
}
