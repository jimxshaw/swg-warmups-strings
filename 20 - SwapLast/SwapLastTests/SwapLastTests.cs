using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwapLast;

namespace SwapLastTests
{
    [TestFixture]
    public class SwapLastTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void SwapLast_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.SwapLast(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
