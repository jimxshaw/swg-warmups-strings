using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MultipleEndings;

namespace MultipleEndingsTests
{
    [TestFixture]
    public class MultipleEndingsTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndings_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.MultipleEndings(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
