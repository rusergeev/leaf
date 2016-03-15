using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SegmentIntersection;

namespace SegmentIntersectionTests
{
    [TestClass()]
    public class SegmentIntersectionsTests
    {
        private static Segment[] NF;
        private static Point[] tipPath;
        private static List<Point> listPrecalculated;
        private static bool turnOffCompare = false;

        const int FNsize = 1000;
        const int tip_num = 1000;

        [ClassInitialize]
        public static void InitFN(TestContext context)
        {
            var rnd = new Random();
            NF = new Segment[FNsize];

            for (int i = 0; i < NF.Length; i++)
            {
                NF[i].start.x = rnd.NextDouble();
                NF[i].start.y = rnd.NextDouble();
                NF[i].end.x = NF[i].start.x + rnd.NextDouble();
                NF[i].end.y = NF[i].start.y + rnd.NextDouble();
            }

            tipPath = new Point[tip_num];

            for (int i = 0; i < tipPath.Length; i++)
            {
                tipPath[i].x = rnd.NextDouble()/10 - rnd.NextDouble()/30;
                tipPath[i].y = rnd.NextDouble()/10 - rnd.NextDouble()/30;
            }

            if (!turnOffCompare)
            {
                listPrecalculated = SegmentIntersections.tip_propagation(tipPath, NF).ToList();
            }

        }

        [TestMethod()]
        public void tip_propagationTest()
        {

            var list = SegmentIntersections.tip_propagation(tipPath, NF).ToList();
            if (!turnOffCompare)
            {
                Assert.IsTrue(list.Count == listPrecalculated.Count);
                var a = list.OrderBy(t => t.x).ToList();
                var b = listPrecalculated.OrderBy(t => t.x).ToList();
                for (int i = 0; i < a.Count; i++)
                {
                    Assert.AreEqual(a[i].x, b[i].x);
                    Assert.AreEqual(a[i].y, b[i].y);
                }
            }
        }


        [TestMethod()]
        public void tip_propagation2XTest()
        {
            var list = SegmentIntersections.tip_propagation2X(tipPath, NF).ToList();
            if (!turnOffCompare)
            {
                Assert.IsTrue(list.Count == listPrecalculated.Count);
                var a = list.OrderBy(t => t.x).ToList();
                var b = listPrecalculated.OrderBy(t => t.x).ToList();
                for (int i = 0; i < a.Count; i++)
                {
                    Assert.AreEqual(a[i].x, b[i].x);
                    Assert.AreEqual(a[i].y, b[i].y);
                }
            }
        }

        [TestMethod()]
        public void tip_propagation2XYTest()
        {
            var list = SegmentIntersections.tip_propagation2XY(tipPath, NF).ToList();
            if (!turnOffCompare)
            {
                Assert.IsTrue(list.Count == listPrecalculated.Count);
                var a = list.OrderBy(t => t.x).ToList();
                var b = listPrecalculated.OrderBy(t => t.x).ToList();
                for (int i = 0; i < a.Count; i++)
                {
                    Assert.AreEqual(a[i].x, b[i].x);
                    Assert.AreEqual(a[i].y, b[i].y);
                }
            }
        }

        [TestMethod()]
        public void tip_propagation2YTest()
        {
            var list = SegmentIntersections.tip_propagation2Y(tipPath, NF).ToList();
            if (!turnOffCompare)
            {
                Assert.IsTrue(list.Count == listPrecalculated.Count);
                var a = list.OrderBy(t => t.x).ToList();
                var b = listPrecalculated.OrderBy(t => t.x).ToList();
                for (int i = 0; i < a.Count; i++)
                {
                    Assert.AreEqual(a[i].x, b[i].x);
                    Assert.AreEqual(a[i].y, b[i].y);
                }
            }
        }
    }
}