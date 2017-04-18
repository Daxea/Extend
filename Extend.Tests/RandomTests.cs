using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extend.Tests
{
    [TestClass]
    public class RandomTests
    {
        [TestMethod]
        public void From_Array_Ints()
        {
            var rand = new Random(1000);
            var array = new int[] { 1, 209, 5, 66, 78, 900, 1029, 89862, 3964, 2346, 20, 489672, 293, 2184 };

            Assert.AreEqual(5, rand.From(array));

            for (int i = 0; i < 100; i++)
                rand.From(array);

            Assert.AreEqual(89862, rand.From(array));
        }

        [TestMethod]
        public void Word_MinMax_Success()
        {
            var rand = new Random(1000);

            Assert.AreEqual("fsarly", rand.Word(6, 10));
        }

        [TestMethod]
        public void Word_Format_Success()
        {
            var rand = new Random(1563);

            Assert.AreEqual("Hijfym Eqiru", rand.Word("Cvccvc Vcvcv"));
        }

        [TestMethod]
        public void Consonant_Success()
        {
            var rand = new Random(1000);

            var expected = "fgtbs";

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], rand.Consonant()[0]);
        }
    }
}