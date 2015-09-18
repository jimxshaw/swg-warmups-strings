using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TweakFront;

namespace TweakFrontTests
{
    [TestFixture]
    public class TweakFrontTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        public void TweakFront_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.TweakFront(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
