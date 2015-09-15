using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeTags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a tag: ");
            string tag = Console.ReadLine();
            Console.Write("Input content: ");
            string content = Console.ReadLine();

            Console.WriteLine(MakeTags(tag, content));

            Console.ReadLine();
        }
        public static string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }
    }
}
