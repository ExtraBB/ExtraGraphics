using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtraGraphics.Shapes;
using ExtraGraphics.Points;
using ExtraGraphics.BoundingBoxes;

namespace ExtraGraphicsTest.BoundingBoxTests
{
    [TestClass]
    public class EllipseBoxTest
    {
        [TestMethod]
        public void IntersectsBoundingBoxTest()
        {
            Ellipse e = new Ellipse(0, 0, 20, 100);
            EllipseBox eb = new EllipseBox(e);


            Assert.AreEqual(true, eb.IntersectsBoundingBox(new Point2D<int>(1, 1)));
            Assert.AreEqual(true, eb.IntersectsBoundingBox(new Point2D<int>(0, 0)));
            Assert.AreEqual(true, eb.IntersectsBoundingBox(new Point2D<int>(20, 20)));
            Assert.AreEqual(true, eb.IntersectsBoundingBox(new Point2D<int>(50, 20)));

            Assert.AreEqual(false, eb.IntersectsBoundingBox(new Point2D<int>(-1, 1)));
            Assert.AreEqual(false, eb.IntersectsBoundingBox(new Point2D<int>(-1, -1)));
            Assert.AreEqual(false, eb.IntersectsBoundingBox(new Point2D<int>(300, 1)));
            Assert.AreEqual(false, eb.IntersectsBoundingBox(new Point2D<int>(int.MaxValue, int.MinValue)));
            
        }

        [TestMethod]
        public void IntersectsShapeTest()
        {
            Ellipse e = new Ellipse(0, 0, 20, 100);
            EllipseBox eb = new EllipseBox(e);


            Assert.AreEqual(true, eb.IntersectsShape(new Point2D<int>(20, 20)));
            Assert.AreEqual(true, eb.IntersectsShape(new Point2D<int>(0, 20)));
            Assert.AreEqual(true, eb.IntersectsShape(new Point2D<int>(100, 5)));
            Assert.AreEqual(true, eb.IntersectsShape(new Point2D<int>(15, 15)));
            Assert.AreEqual(true, eb.IntersectsShape(new Point2D<int>(45, 30)));

            Assert.AreEqual(false, eb.IntersectsShape(new Point2D<int>(-1, 1)));
            Assert.AreEqual(false, eb.IntersectsShape(new Point2D<int>(-1, -1)));
            Assert.AreEqual(false, eb.IntersectsShape(new Point2D<int>(300, 1)));
            Assert.AreEqual(false, eb.IntersectsShape(new Point2D<int>(int.MaxValue, int.MinValue)));
        }
    }
}
