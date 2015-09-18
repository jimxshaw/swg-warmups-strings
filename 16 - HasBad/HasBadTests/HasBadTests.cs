using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HasBad;

namespace HasBadTests
{   
    [TestFixture]
    public class HasBadTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        public void HasBad_String_ReturnBool(string str, bool expectedResult)
        {
            bool result = _program.HasBad(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
