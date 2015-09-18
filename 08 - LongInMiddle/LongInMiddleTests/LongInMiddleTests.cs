using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LongInMiddle;

namespace LongInMiddleTests
{
    [TestFixture]
    public class LongInMiddleTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddle_Strings_ReturnConcatenation(string a, string b, string expectedResult)
        {
            string result = _program.LongInMiddle(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
