using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AtFirst;

namespace AtFirstTests
{
    [TestFixture]
    public class AtFirstTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void AtFirst_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.AtFirst(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
