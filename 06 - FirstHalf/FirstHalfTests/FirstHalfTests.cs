using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FirstHalf;

namespace FirstHalfTests
{
    [TestFixture]
    public class FirstHalfTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalf_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.FirstHalf(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
