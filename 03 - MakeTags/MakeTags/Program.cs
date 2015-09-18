using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeTags
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Input a tag: ");
            string tag = Console.ReadLine();
            Console.Write("Input content: ");
            string content = Console.ReadLine();

            Console.WriteLine(program.MakeTags(tag, content));

            Console.ReadLine();
        }
        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }
    }
}
