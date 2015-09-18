using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Input first word: ");
            string wordA = Console.ReadLine();
            Console.Write("Input second word: ");
            string wordB = Console.ReadLine();

            Console.WriteLine(program.ConCat(wordA, wordB));

            Console.ReadLine();
        }

        public string ConCat(string a, string b)
        {
            if (a.Length == 0)
            {
                return b;
            }
            if (b.Length == 0)
            {
                return a;
            }
            if (a.Substring(a.Length - 1) == b.Substring(0, 1))
            {
                a = a.Remove(a.Length - 1);

                return a + b;
            }
            
            return a + b;
        }
    }
}
