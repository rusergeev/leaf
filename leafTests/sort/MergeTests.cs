using leaf;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace leaf.Tests
{
    [TestClass]
    public class MergeTests
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

            Merge.sort(A);

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

            Merge.sort(A);

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

            Merge.sort(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[i] <= A[i + 1]);
            }

        }

        [TestMethod]
        public void sortbottomupTest()
        {
            var rnd = new Random();
            var A = new int[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next();
            }

            Merge.sortbottomup(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[i] <= A[i + 1]);
            }

        }

        [TestMethod]
        public void sortbottomupSortedTest()
        {
            var A = new int[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = i / 3;
            }

            Merge.sortbottomup(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[i] <= A[i + 1]);
            }

        }
        [TestMethod]
        public void sortbottomupReversedTest()
        {
            var A = new int[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = (size - i) / 3;
            }

            Merge.sortbottomup(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[i] <= A[i + 1]);
            }

        }
    }
}