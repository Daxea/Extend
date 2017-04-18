using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extend.Tests
{
    [TestClass]
    public class StringTests
    {
        #region IsEmpty

        [TestMethod]
        public void IsEmpty_True_Empty()
        {
            var text = string.Empty;

            Assert.IsTrue(text.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_True_Null()
        {
            string text = null;

            Assert.IsTrue(text.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_False()
        {
            var text = "I am not empty";

            Assert.IsFalse(text.IsEmpty());
        }

        #endregion
        #region IsEmptyOrWhitespace

        [TestMethod]
        public void IsEmptyOrWhitespace_True_Empty()
        {
            var text = string.Empty;

            Assert.IsTrue(text.IsEmptyOrWhitespace());
        }

        [TestMethod]
        public void IsEmptyOrWhitespace_True_Whitespace()
        {
            var text = "          ";

            Assert.IsTrue(text.IsEmptyOrWhitespace());
        }

        [TestMethod]
        public void IsEmptyOrWhitespace_True_Null()
        {
            string text = null;

            Assert.IsTrue(text.IsEmptyOrWhitespace());
        }

        [TestMethod]
        public void IsEmptyOrWhitespace_False()
        {
            var text = "I am not whitespace or null or empty.";

            Assert.IsFalse(text.IsEmptyOrWhitespace());
        }

        #endregion
        #region Calculate Similarity

        [TestMethod]
        public void CalculateSimilarity_100()
        {
            var text = "1234567890";

            Assert.AreEqual(1f, text.CalculateSimilarity("1234567890"));
        }

        [TestMethod]
        public void CalculateSimilarity_90()
        {
            var text = "1234567890";

            Assert.AreEqual(0.9f, text.CalculateSimilarity("123456789"));
        }

        [TestMethod]
        public void CalculateSimilarity_50()
        {
            var text = "1234567890";

            Assert.AreEqual(0.5f, text.CalculateSimilarity("133557788"));
        }

        [TestMethod]
        public void CalculateSimilarity_10()
        {
            var text = "1234567890";

            Assert.AreEqual(0.1f, text.CalculateSimilarity("9876512344"));
        }

        #endregion
    }
}