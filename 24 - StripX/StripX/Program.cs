using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Input a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(program.StripX(word));
            Console.ReadLine();
        }

        public string StripX(string str)
        {
            if (str.StartsWith("x") && str.EndsWith("x"))
            {
                return str.Substring(1, str.Length - 2);
            }
            if (str.StartsWith("x"))
            {
                str = str.Remove(0, 1);
                return str;
            }
            if (str.EndsWith("x"))
            {
                str = str.Remove(str.Length - 1);
                return str;
            }

            return str;
        }
    }
}
