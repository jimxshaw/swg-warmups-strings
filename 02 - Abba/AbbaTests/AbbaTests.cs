using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Abba;

namespace AbbaTests
{
    [TestFixture]
    class AbbaTests
    {
        private Program _program;

        [SetUp]
        public void BeforeEachTest()
        {
            _program = new Program();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void Abba_Strings_ReturnConcatenation(string a, string b, string expectedResult)
        {
            string result = _program.Abba(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
