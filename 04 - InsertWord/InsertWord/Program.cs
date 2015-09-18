using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a container: ");
            string container = Console.ReadLine();
            Console.Write("Input a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(program.InsertWord(container, word));

            Console.ReadLine();
        }
        public string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2);
        }
    }
}
