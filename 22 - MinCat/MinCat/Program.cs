using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first word: ");
            string wordA = Console.ReadLine();
            Console.Write("Input second word: ");
            string wordB = Console.ReadLine();

            Console.WriteLine(MinCat(wordA, wordB));

            Console.ReadLine();
        }

        public static string MinCat(string a, string b)
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
