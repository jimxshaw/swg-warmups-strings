using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TakeTwoFromPosition;

namespace TakeTwoFromPositionTests
{
    [TestFixture]
    public class TakeTwoFromPositionTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPosition_String_ReturnSubstring(string str, int n, string expectedResult)
        {
            string result = _program.TakeTwoFromPosition(str, n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
