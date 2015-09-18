using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MinCat;

namespace MinCatTests
{
    [TestFixture]
    public class MinCatTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        public void MinCat_Strings_ReturnSubstring(string strA, string strB, string expectedResult)
        {
            string result = _program.MinCat(strA, strB);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
