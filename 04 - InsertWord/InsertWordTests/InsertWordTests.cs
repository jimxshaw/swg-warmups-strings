using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InsertWord;

namespace InsertWordTests
{
    [TestFixture]
    public class InsertWordTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWord_Word_ReturnWordInContainer(string container, string word, string expectedResult)
        {
            string result = _program.InsertWord(container, word);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
