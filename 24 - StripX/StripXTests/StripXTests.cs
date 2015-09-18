using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StripX;

namespace StripXTests
{
    [TestFixture]
    public class StripXTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void StripX_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.StripX(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}