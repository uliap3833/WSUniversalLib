using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTests
{
    [TestClass]
    public class HardTest
    {
        [TestMethod]
        public void GetExtraValueProduct()
        {
            int actual, expected;
            expected = 1141982000;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, 200000000000, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetExtraNegativeValueProduct()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, -200000000000, 45);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetExtraProductMaterialType()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1000000, 15, 20, 45);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetExtraNegativeProductMaterialType()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, -1000000, 150, 200.1f, 450.2f);
            Assert.AreEqual(expected, actual);
        }
    }
}

