using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SegmentIntersections.Tests
{
    [TestClass]
    public class InsertionTests
    {
        const int size = 20000;
        [TestMethod]
        public void sortTest()
        {
            var rnd = new Random();
            var A = new int[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next();
            }

            Insertion.sort(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[i] <= A[i + 1]);
            }

        }

        [TestMethod]
        public void sortSortedTest()
        {
            var A = new int[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = i / 3;
            }

            Insertion.sort(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[i] <= A[i + 1]);
            }

        }
        [TestMethod]
        public void sortReversedTest()
        {
            var A = new int[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = (size - i) / 3;
            }

            Insertion.sort(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[i] <= A[i + 1]);
            }

        }
    }
}