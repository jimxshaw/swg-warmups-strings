using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FrontAndBack;

namespace FrontAndBackTests
{
    [TestFixture]
    public class FrontAndBackTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBack_String_ReturnSubstring(string str, int n, string expectedResult)
        {
            string result = _program.FrontAndBack(str, n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
