using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateCircleSq()
        {
            double expectedVal = 3.14;
            string expectedDesc = "Circle";

            int radius = 1;

            var result = Calculator.CalcSq(radius);

            double actualVal = result.Item1;
            string actualDesc = result.Item2;

            Assert.AreEqual(expectedVal, Math.Round(actualVal, 2));
            Assert.AreEqual(expectedDesc, actualDesc);
        }
        [TestMethod]
        public void CalculateTriangleSqNOTEXISTS()
        {
            int[] parameters = { 1, 5, 8 };

            double expectedVal = 0.0;
            string expectedDesc = "NE";

            var result = Calculator.CalcSq(parameters);

            var actualVal = result.Item1;
            var actualDesc = result.Item2;

            Assert.AreEqual(expectedVal, actualVal);
            Assert.AreEqual(expectedDesc, actualDesc);

        }
        [TestMethod]
        public void CalculateRectTriangleSq()
        {
            int[] parameters = { 3, 4, 5 };

            double expectedVal = 6;
            string expectedDesc = "Rectangular Triangle";

            var result = Calculator.CalcSq(parameters);

            var actualVal = result.Item1;
            var actualDesc = result.Item2;

            Assert.AreEqual(expectedVal, actualVal);
            Assert.AreEqual(expectedDesc, actualDesc);
        }
        [TestMethod]
        public void CalculateTriangleSq()
        {
            int[] parameters = { 6, 4, 7 };

            double expectedVal = 8;
            string expectedDesc = "Triangle";

            var result = Calculator.CalcSq(parameters);

            var actualVal = result.Item1;
            var actualDesc = result.Item2;

            Assert.AreEqual(expectedVal, actualVal);
            Assert.AreEqual(expectedDesc, actualDesc);
        }
    }
}
