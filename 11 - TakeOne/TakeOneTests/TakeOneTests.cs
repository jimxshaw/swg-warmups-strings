using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TakeOne;

namespace TakeOneTests
{
    [TestFixture]
    public class TakeOneTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOne_String_ReturnSubstring(string str, bool fromFront, string expectedResult)
        {
            string result = _program.TakeOne(str, fromFront);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
