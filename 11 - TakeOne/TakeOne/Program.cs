using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.Write("Take first letter? (y or n): ");
            string fromFront = Console.ReadLine();

    
            if (fromFront == "y")
            {
                Console.WriteLine(program.TakeOne(word, true));
            }
            else if (fromFront == "n")
            {
                Console.WriteLine(program.TakeOne(word, false));
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.ReadLine();
        }

        public string TakeOne(string str, bool fromFront)
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
