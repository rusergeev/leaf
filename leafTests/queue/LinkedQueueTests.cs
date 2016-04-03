using Microsoft.VisualStudio.TestTools.UnitTesting;
using leaf.queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaf.queue.Tests
{
    [TestClass()]
    public class LinkedQueueTests
    {
        private const int size = 10000;
        private static readonly int[] A = new int[size];

        [ClassInitialize]
        static void Initialize()
        {
            var rnd = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next();
            }
        }

        [TestMethod()]
        public void QueueTestShort()
        {
            var queue = new LinkedQueue<int>();
            Assert.IsNotNull(queue);
            Assert.IsTrue(queue.isEmpty());
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);
            Assert.IsFalse(queue.isEmpty());
            var queue2 = new LinkedQueue<int>();
            Assert.IsNotNull(queue2);
            foreach (var value in queue)
            {
                queue2.enqueue(value);
            }
            while (!queue.isEmpty() && !queue2.isEmpty())
            {
                Assert.AreEqual(queue.dequeue(),  queue2.dequeue());
            }
            Assert.IsTrue(queue.isEmpty());
            Assert.IsTrue(queue2.isEmpty());
        }

        [TestMethod()]
        public void QueueTestRandom()
        {
            var queue = new LinkedQueue<int>();
            Assert.IsNotNull(queue);
            Assert.IsTrue(queue.isEmpty());
            foreach (var value in A)
            {
                queue.enqueue(value);
                Assert.IsFalse(queue.isEmpty());
            }
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(queue.dequeue(), A[i]);
            }
            Assert.IsTrue(queue.isEmpty());
        }
    }
}