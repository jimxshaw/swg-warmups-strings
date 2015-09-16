using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.Write("Take first letter? (y or n): ");
            string fromFront = Console.ReadLine();

    
            if (fromFront == "y")
            {
                Console.WriteLine(TakeOne(word, true));
            }
            else if (fromFront == "n")
            {
                Console.WriteLine(TakeOne(word, false));
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.ReadLine();
        }

        public static string TakeOne(string str, bool fromFront)
        {
            if (fromFront)
            {
                return str.Remove(1);
            }
            else
            {
                return str.Remove(0, str.Length - 1);
            }
        }
    }
}
