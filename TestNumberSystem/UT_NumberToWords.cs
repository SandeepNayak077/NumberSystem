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

        [TestMethod]
        public void T0002_Spells__In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(5220);
            string expectedResult = "five thousand, two hundred and twenty";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void T0003_Spells__In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(22511);
            string expectedResult = "Twenty-two thousand, five hundred and eleven";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void T0004_Spells__In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(325402);
            string expectedResult = "Three hundred and twenty-five thousand, four hundred and two";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void T0005_Spells__In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(4132316);
            string expectedResult = "Four million, one hundred and thirty-two thousand, three hundred and sixteen";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void T0006_Spells__In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(25212423);
            string expectedResult = "Twenty-five million, two hundred and twelve thousand, four hundred and twenty-three";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void T0007_Spells__In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(315121810);
            string expectedResult = "Three hundred and fifteen million, one hundred and twenty-one thousand, eight hundred and ten";
            Assert.AreEqual(expectedResult, actualResult);
        }        
    }
}
