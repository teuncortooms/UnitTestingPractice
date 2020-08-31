using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralConverterNamespace;
using System;

namespace RomanNumeralConverterTests
{
    [TestClass]
    public class RomanNumeralConverterOutOfRangeTests
    {
        [TestMethod]
        public void Convert_above_3000_throws_exception()
        {
            RomanNumeralConverter c = new RomanNumeralConverter();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.Convert(3001));
        }

        [TestMethod]
        public void Convert_below_0_throws_exception()
        {
            RomanNumeralConverter c = new RomanNumeralConverter();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.Convert(-1));
        }

        [TestMethod]
        public void Convert_0_throws_exception()
        {
            RomanNumeralConverter c = new RomanNumeralConverter();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.Convert(0));
        }
    }

    [TestClass]
    public class RomanNumeralConverterExpectedValuesTests
    {
        [TestMethod]
        public void Convert_5_should_return_V()
        {
            RomanNumeralConverter c = new RomanNumeralConverter();
            string romans = c.Convert(5);
            Assert.AreEqual("V", romans);
        }

        [TestMethod]
        public void Convert_6_should_return_VI()
        {
            RomanNumeralConverter c = new RomanNumeralConverter();
            string romans = c.Convert(6);
            Assert.AreEqual("VI", romans);
        }

        [TestMethod]
        public void Convert_2999_should_return_MMDCCCCLXXXXVIIII()
        {
            RomanNumeralConverter c = new RomanNumeralConverter();
            string romans = c.Convert(2999);
            Assert.AreEqual("MMDCCCCLXXXXVIIII", romans);
        }
    }
}
