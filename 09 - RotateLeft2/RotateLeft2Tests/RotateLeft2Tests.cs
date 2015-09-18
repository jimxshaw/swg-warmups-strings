using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RotateLeft2;

namespace Rotate2Tests
{
    [TestFixture]
    public class RotateLeft2Tests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateLeft2_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.RotateLeft2(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
