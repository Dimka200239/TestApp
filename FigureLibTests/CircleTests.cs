using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FigureLib.Figure;


namespace FigureLibTests
{
    [TestClass]
    public class CircleTests
    {
        private Circle newCircle;

        [TestMethod]
        public void ConstructorTestForLargeValues()
        {
            newCircle = new Circle(999999);
        }

        [TestMethod]
        public void ConstructorTestForSmallValues()
        {
            newCircle = new Circle(0.000001);
        }

        [TestMethod()]
        public void ConstructorTestForNegativeValues()
        {
            try
            {
                newCircle = new Circle(-1234);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Радиус не может быть <= 0", e.Message);
            }
        }
    }
}
