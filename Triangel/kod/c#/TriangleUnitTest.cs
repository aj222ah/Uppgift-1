using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleUnitTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void testConstructorPoint()
        {
            Point valPoint = new Point(2.6, 1.8);
            Assert.IsNotNull(valPoint);
        }
        
        [TestMethod]
        public void testTriangleValid()
        {
            Triangle triVal = new Triangle(2.6, 2.9, 1.8);
            Assert.IsNotNull(triVal);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testTriangleNegativeValues()
        {
            // Triangel med negativa värden
            var triInval1 = new Triangle(-2.6, -2.9, -1.8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testTriangleInequality()
        {
            // Ogiltig triangel enligt triangelolikheten
            var triInval2 = new Triangle(2, 3, 6);
        }

        [TestMethod]
        public void testTriangleIsScalene()
        {
            Triangle triScal = new Triangle(1.5, 2.5, 3.7);
            Assert.IsTrue(triScal.isScalene());
        }

        [TestMethod]
        public void testTriangleIsEquilateral()
        {
            Triangle triEqui = new Triangle(12.6, 12.6, 12.6);
            Assert.IsTrue(triEqui.isEquilateral());
        }

        [TestMethod]
        public void testTriangleIsIsosceles()
        {
            Triangle triIso = new Triangle(25.2, 14.3, 25.2);
            Assert.IsTrue(triIso.isIsosceles());
        }

        [TestMethod]
        public void testTriangleIsNotScalene()
        {
            Triangle triNotScal = new Triangle(25.2, 14.3, 25.2);
            Assert.IsFalse(triNotScal.isScalene());
        }

        [TestMethod]
        public void testTriangleIsNotEquilateral()
        {
            Triangle triNotEqui = new Triangle(1.5, 2.5, 1.5);
            Assert.IsFalse(triNotEqui.isEquilateral());
        }

        [TestMethod]
        public void testTriangleIsNotIsosceles()
        {
            Triangle triNotIso = new Triangle(1.5, 2.5, 3.7);
            Assert.IsFalse(triNotIso.isIsosceles());
        }
    }
}
