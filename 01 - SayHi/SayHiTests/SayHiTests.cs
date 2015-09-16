using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SayHi;

// To test properly,
// 1) add the NUnit Package
// 2) add -> reference for the other program

namespace SayHiTests
{
    [TestFixture]
    public class SayHiTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHi_Name_ReturnHiName(string name, string expectedResult)
        {
            string result = Program.SayHi(name);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
