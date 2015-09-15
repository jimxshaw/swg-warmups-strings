using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a container: ");
            string container = Console.ReadLine();
            Console.Write("Input a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(InsertWord(container, word));

            Console.ReadLine();
        }
        public static string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2);
        }
    }
}
