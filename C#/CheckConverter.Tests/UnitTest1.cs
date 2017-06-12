using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckConverter.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertSingleDigitTest()
        {
            Assert.AreEqual(CheckConverter.Program.ConvertToWords(7.ToString()), "Seven Only");
        }

        [TestMethod]
        public void ConvertMultiDigitTest()
        {
            Assert.AreEqual(CheckConverter.Program.ConvertToWords(2683.ToString()), "Two Thousand Six Hundred Eighty Three Only");
        }

        [TestMethod]
        public void ConvertInvalidDigitTest()
        {
            Assert.AreEqual(CheckConverter.Program.ConvertToWords("Eleventy One"), " Only");
        }
    }
}
