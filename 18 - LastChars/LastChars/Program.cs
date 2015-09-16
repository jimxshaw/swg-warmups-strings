using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first word: ");
            string strA = Console.ReadLine();
            Console.Write("Input second word: ");
            string strB = Console.ReadLine();
            Console.WriteLine(LastChars(strA, strB));

            Console.ReadLine();
        }

        public static string LastChars(string strA, string strB)
        {
            if (strA.Length == 0)
            {
                strA = "@";
            }
            if (strB.Length == 0)
            {
                strB = "@";
            }
            return strA.Substring(0, 1) + strB.Substring(strB.Length - 1);
        }
    }
}
