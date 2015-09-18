using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TrimOne;

namespace TrimOneTests
{
    [TestFixture]
    public class TrimOneTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOne_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.TrimOne(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
