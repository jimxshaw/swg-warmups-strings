using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FrontAgain;

namespace FrontAgainTests
{
    [TestFixture]
    public class FrontAgainTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgain_String_ReturnBool(string str, bool expectedResult)
        {
            bool result = _program.FrontAgain(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
