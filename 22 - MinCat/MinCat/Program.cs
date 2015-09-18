using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCat
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

            Console.WriteLine(program.MinCat(wordA, wordB));

            Console.ReadLine();
        }

        public string MinCat(string a, string b)
        {
            if (a.Length == b.Length)
            {
                return a + b;
            }
            if (a.Length > b.Length)
            {
                int differenceA = a.Length - b.Length;

                a = a.Remove(0, differenceA);

                return a + b;
            }

            int differenceB = b.Length - a.Length;

            b = b.Remove(0, differenceB);

            return a + b;
        }
    }
}
