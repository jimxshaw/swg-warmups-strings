using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConCat;

namespace ConCatTests
{
    [TestFixture]
    public class ConCatTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCat_Strings_ReturnConcatenation(string strA, string strB, string expectedResult)
        {
            string result = _program.ConCat(strA, strB);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
