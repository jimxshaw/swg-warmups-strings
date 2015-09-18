using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RotateRight2;

namespace RotateRight2Tests
{
    [TestFixture]
    public class RotateRight2Tests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _program.RotateRight2(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
