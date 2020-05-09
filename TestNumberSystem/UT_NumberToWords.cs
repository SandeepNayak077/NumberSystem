using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystem;

namespace TestNumberSystem
{
    [TestClass]
    public class UT_NumberToWords
    {
        [TestMethod]
        public void T0001_BasicTest()
        {
            string actualResult = NumberToWords.Convert(1234);
            string expectedResult = "One Thousand, Two Hundred and Thirty-Four";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
