using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo.Tests
{
    [TestClass()]
    public class TestingStuffTests
    {
        [TestMethod()]
        public void hasAVowelTest()
        {
            TestingStuff ts = new TestingStuff();

            Assert.IsTrue(ts.hasAVowel("foo"), "data = o");
            Assert.IsTrue(ts.hasAVowel("elf"), "data = e");
            Assert.IsTrue(ts.hasAVowel("in"), "data = i");
            Assert.IsTrue(ts.hasAVowel("app"), "data = a");
            Assert.IsTrue(ts.hasAVowel("trunk"), "data = u");

            Assert.IsFalse(ts.hasAVowel("rhythm"), "data = rhythm");
            Assert.IsFalse(ts.hasAVowel(""), "data = empty string");
            Assert.IsFalse(ts.hasAVowel("bcdfghjklmnpqrstvwxyz"), "data = consonents");
            //Assertion = statement of fact
        }
    }
}