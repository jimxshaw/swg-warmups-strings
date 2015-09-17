using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweakFront
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a word: ");
            string word = Console.ReadLine();
            Console.WriteLine(TweakFront(word));

            Console.ReadLine();
        }

        public static string TweakFront(string str)
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
