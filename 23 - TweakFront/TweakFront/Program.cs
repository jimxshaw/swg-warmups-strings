using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweakFront
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.WriteLine(program.TweakFront(word));

            Console.ReadLine();
        }

        public string TweakFront(string str)
        {
            if (str.StartsWith("ab"))
            {
                return str;
            }
            if (str.IndexOf("a") != 0 && str.IndexOf("b") != 1)
            {
                str = str.Remove(0, 2);

                return str;
            }
            if (str.IndexOf("b") == 1)
            {
                str = str.Remove(0, 1);

                return str;
            }
            if (str.IndexOf("a") == 0)
            {
                str = str.Remove(1, 1);

                return str;
            }
                return str;

        }
    }
}
