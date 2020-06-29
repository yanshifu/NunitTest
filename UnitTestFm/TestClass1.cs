using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFm
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
