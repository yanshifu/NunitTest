// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using ConsoleApp2;
using NUnit.Framework;

namespace NUnit.Tests2
{
    [TestFixture]
    public class TestClass1
    {
        Program program = new Program();
        [Test]
        public void TestIsValid()
        {
            // TODO: Add your test code here

            Assert.AreEqual(true, program.IsValid(102));

        }
        [Test]
        public void TestIsEqual()
        {
            // TODO: Add your test code here

            Assert.AreEqual(9, program.AddData(4, 5));

        }
    }
}
