using AF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        private IShape shape = null!;
        [TestMethod]
        [ExpectedException(typeof(Exception), "Радиус меньше или равен 0")]
        public void TestMethod1()
        {
            shape = new Circle(-5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            shape = new Circle(5);
            var ar = Math.Round(shape.GetArea(), 2);
            var p = Math.Round(shape.GetPerimeter(), 2);
            Assert.IsTrue(Math.Abs(78.50 - ar) <= 0.1);
            Assert.IsTrue(Math.Abs(31.40 - p) <= 0.1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            shape = new Circle(3.0946);
            var ar = Math.Round(shape.GetArea(), 2);
            var p = Math.Round(shape.GetPerimeter(), 2);
            Assert.IsTrue(Math.Abs(30.07 - ar) <= 0.1);
            Assert.IsTrue(Math.Abs(19.44 - p) <= 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Не выполняется теорема о неравенстве треугольника")]
        public void TestMethod4()
        {
            shape = new Triangle(0, -4, 3);
        }
        [TestMethod]
        public void TestMethod5()
        {
            shape = new Triangle(5, 6, 3);
            var ar = Math.Round(shape.GetArea(), 2);
            var p = Math.Round(shape.GetPerimeter(), 2);
            Assert.IsTrue(Math.Abs(7.48 - ar) <= 0.1);
            Assert.IsTrue(Math.Abs(14 - p) <= 0.1);
            Assert.AreEqual(((Triangle)shape).IsRightTriangle(), false);
        }
        [TestMethod]
        public void TestMethod6()
        {
            shape = new Triangle(3, 4, 5);
            var ar = Math.Round(shape.GetArea(), 2);
            var p = Math.Round(shape.GetPerimeter(), 2);
            Assert.IsTrue(Math.Abs(6 - ar) <= 0.1);
            Assert.IsTrue(Math.Abs(12 - p) <= 0.1);
            Assert.AreEqual(((Triangle)shape).IsRightTriangle(), true);
        }
    }
}