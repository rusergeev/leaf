using leaf.priority;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leafTests.priority
{
    [TestClass]
    public class MaxPQTests
    {
        [TestMethod]
        public void IsEmptyTest()
        {
            var pq = new MaxPQ<int>(10);
            Assert.IsTrue(pq.IsEmpty());
            pq.Insert(0);
            Assert.IsFalse(pq.IsEmpty());
            pq.DelTop();
            Assert.IsTrue(pq.IsEmpty());
        }

        [TestMethod]
        public void TopTest()
        {
            var pq = new MaxPQ<int>(10);
            Assert.IsTrue(pq.IsEmpty());
            pq.Insert(0);
            Assert.AreEqual(pq.Top(), 0);
            pq.Insert(2);
            Assert.AreEqual(pq.Top(), 2);
            pq.Insert(1);
            Assert.AreEqual(pq.Top(), 2);
            pq.DelTop();
            Assert.AreEqual(pq.Top(), 1);
        }

        [TestMethod]
        public void SizeTest()
        {
            var pq = new MaxPQ<int>(10);
            Assert.AreEqual(pq.Size(), 0);
            pq.Insert(0);
            Assert.AreEqual(pq.Size(), 1);
            pq.DelTop();
            Assert.AreEqual(pq.Size(), 0);
        }

        [TestMethod]
        public void InsertTest()
        {
            var pq = new MaxPQ<int>(10);
            pq.Insert(356);
            Assert.AreEqual(pq.Top(), 356);
        }

        [TestMethod]
        public void DelTopTest()
        {
            var pq = new MaxPQ<int>(10);
            pq.Insert(35);
            pq.Insert(356);
            pq.Insert(56);
            Assert.AreEqual(pq.DelTop(), 356);
            Assert.AreEqual(pq.Top(), 56);
        }
    }
}