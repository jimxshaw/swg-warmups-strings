using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MakeTags;

namespace MakeTagsTests
{
    [TestFixture]
    public class MakeTagsTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTags_Tags_ReturnTagsAndContent(string tag, string content, string expectedResult)
        {
            string result = _program.MakeTags(tag, content);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
