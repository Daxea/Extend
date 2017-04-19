using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extend.Tests
{
    [TestClass]
    public class Int32Tests
    {
        [TestMethod]
        public void Pow_2x3()
        {
            Assert.AreEqual(8, 2.Pow(3));
        }

        [TestMethod]
        public void Pow_3x3()
        {
            Assert.AreEqual(27, 3.Pow(3));
        }

        [TestMethod]
        public void Sqr_2()
        {
            Assert.AreEqual(4, 2.Sqr());
        }

        [TestMethod]
        public void Sqrt_1024()
        {
            Assert.AreEqual(32, 1024.Sqrt());
        }
    }
}