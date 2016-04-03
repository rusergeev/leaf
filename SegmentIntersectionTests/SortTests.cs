using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SegmentIntersection;

namespace SegmentIntersectionTests
{
    [TestClass]
    public class SortByIndexTests
    {
        const int size = 2000;

        [TestMethod]
        public void SortByIndexTest()
        {
            var rnd = new Random();
            var A = new double[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.NextDouble();
            }

            var index = IndexSort<double>.SortIndex(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[index[i]] <= A[index[i + 1]]);
            }
        }
    }
}