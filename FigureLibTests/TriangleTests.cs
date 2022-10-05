using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FigureLib.Figure;

namespace FigureLibTests
{
    [TestClass]
    public class TriangleTests
    {
        private Triangle newTriangle;

        [TestMethod]
        public void ConstructorTestForLargeValues()
        {
            newTriangle = new Triangle("9999", "7777", "2256");
        }

        [TestMethod]
        public void ConstructorTestForSmallValues()
        {
            newTriangle = new Triangle("0,0003", "0,0004", "0,0005");
        }

        [TestMethod()]
        public void ConstructorTestForNegativeValues()
        {
            try
            {
                newTriangle = new Triangle("0,0003", "-0,0004", "0,0005");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Треугольник со сторонами 0,0003, -0,0004, 0,0005 существовать не может", e.Message);
            }
        }

        [TestMethod()]
        public void TestForNonExistentTriangle()
        {
            try
            {
                newTriangle = new Triangle("10", "4", "3");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Треугольник со сторонами 10, 4, 3 существовать не может", e.Message);
            }
        }

        [TestMethod()]
        public void TestInputIsNotANumber()
        {
            try
            {
                newTriangle = new Triangle("sgsffsdfsd", "4", "3");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Некорректное значение сторон треугольника", e.Message);
            }
        }
    }
}
