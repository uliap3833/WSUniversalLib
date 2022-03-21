using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void GetQuantityForProduct()
        {
            int actual, expected;
            expected = 114148;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForNoExistTypeMaterial()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 63, 15, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForNoExistTypeProduct()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(345, 1, 15, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForNoExistProduct()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 953, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNegativeProductValueCount()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 2, -15, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNegativeProductValueWidth()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, -31, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNegativeProductValueLenght()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, 20, -45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNullProductLenght()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, 20, 0);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetNullProductWidth()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, 0, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNullProductTypeMaterial()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 0, 20, 45);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void GetQuantityForProduct_FloatValueWidth()
        {
            int actual, expected;
            expected = 190;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, 2.0f, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_FloatValueLenght()
        {
            int actual, expected;
            expected = 190;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, 20, 4.5f);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetExtraValueProductHard()
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
        public void GetExtraProductMaterialTypeHard()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1000000, 15, 20, 45);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetExtraNegativeProductMaterialTypeHard()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, -1000000, 150, 200.1f, 450.2f);
            Assert.AreEqual(expected, actual);
        }
    }
    
}
