using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EndsWithLy;

namespace EndsWithLyTests
{
    [TestFixture]
    public class EndsWithLyTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLy_String_ReturnBool(string str, bool expectedResult)
        {
            bool result = _program.EndsWithLy(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
