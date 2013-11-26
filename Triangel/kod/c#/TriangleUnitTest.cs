using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleUnitTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void testTriangleValid()
        {
            Triangle triVal = new Triangle(2.6, 2.9, 1.8);
            Assert.IsNotNull(triVal);
        }

        [TestMethod]
        public void testTriangleInvalidNegativeNumbers()
        {
            Triangle triInval1 = new Triangle(-2.6, -2.9, -1.8);
            Assert.IsNotNull(triInval1);
        }

        [TestMethod]
        public void testTriangleInvalidTriangleInequality()
        {
            Triangle triInval2 = new Triangle(2, 3, 6);
            Assert.IsNotNull(triInval2);
        }

        [TestMethod]
        public void testTriangleScalene()
        {
            Triangle triScal = new Triangle(1.5, 2.5, 3.7);
            Assert.IsTrue(triScal.isScalene());
            Assert.IsFalse(triScal.isIsosceles());
            Assert.IsFalse(triScal.isEquilateral());
        }

        [TestMethod]
        public void testTriangleEquilateral()
        {
            Triangle triEqui = new Triangle(12.6, 12.6, 12.6);
            Assert.IsFalse(triEqui.isScalene());
            Assert.IsFalse(triEqui.isIsosceles());
            Assert.IsTrue(triEqui.isEquilateral());
        }

        [TestMethod]
        public void testTriangleIsosceles()
        {
            Triangle triIso = new Triangle(25.2, 14.3, 25.2);
            Assert.IsFalse(triIso.isScalene());
            Assert.IsTrue(triIso.isIsosceles());
            Assert.IsFalse(triIso.isEquilateral());
        }
    }
}
