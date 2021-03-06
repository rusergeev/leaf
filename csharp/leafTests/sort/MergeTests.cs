﻿using System;
using leaf;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leafTests.sort
{
    [TestClass]
    public class MergeSortTests
    {
        const int size = 2000;
        [TestMethod]
        public void sortTest()
        {
            var rnd = new Random();
            var A = new int[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next();
            }

            Merge<int>.sort(A);

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

            Merge<int>.sort(A);

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

            Merge<int>.sort(A);

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

            Merge<int>.sortbottomup(A);

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

            Merge<int>.sortbottomup(A);

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

            Merge<int>.sortbottomup(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                Assert.IsTrue(A[i] <= A[i + 1]);
            }

        }
    }
}