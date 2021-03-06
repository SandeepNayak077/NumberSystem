﻿using System;
using System.Globalization;
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
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0002_Spells_5220_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(5220);
            string expectedResult = "five thousand, two hundred and twenty";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0003_Spells_22511_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(22511);
            string expectedResult = "Twenty-two thousand, five hundred and eleven";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0004_Spells_325402_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(325402);
            string expectedResult = "Three hundred and twenty-five thousand, four hundred and two";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0005_Spells_4132316_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(4132316);
            string expectedResult = "Four million, one hundred and thirty-two thousand, three hundred and sixteen";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0006_Spells_25212423_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(25212423);
            string expectedResult = "Twenty-five million, two hundred and twelve thousand, four hundred and twenty-three";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0007_Spells_315121810_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(315121810);
            string expectedResult = "Three hundred and fifteen million, one hundred and twenty-one thousand, eight hundred and ten";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0008_Spells_0_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(0);
            string expectedResult = "Zero";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0009_Spells_10_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(10);
            string expectedResult = "Ten";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0010_Spells_100_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(100);
            string expectedResult = "One Hundred";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0011_Spells_1000_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(1000);
            string expectedResult = "One thousand";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0012_Spells_1000000_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(1000000);
            string expectedResult = "One million";
            Assert.AreEqual(expectedResult, actualResult, true);
        }

        [TestMethod]
        public void T0013_Spells_Negative_Number_In_International_Numbering_System()
        {
            string actualResult = NumberToWords.Convert(-1234);
            string expectedResult = "Minus One Thousand, Two Hundred and Thirty-Four";
            Assert.AreEqual(expectedResult, actualResult, true);
        }
    }
}
