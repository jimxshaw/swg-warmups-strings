using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LastChars;

namespace LastCharsTests
{
    [TestFixture]
    public class LastCharsTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        public void LastChars_String_ReturnSubstring(string strA, string strB, string expectedResult)
        {
            string result = _program.LastChars(strA, strB);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
