using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MiddleTwo;

namespace MiddleTwoTests
{
    [TestFixture]
    public class MiddleTwoTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwo_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.MiddleTwo(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
