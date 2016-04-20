using System;
using leaf.stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leafTests.stack
{
    public class IStackTests
    {
        private const int size = 10000;
        private static readonly int[] A = new int[size];

        static IStackTests()
        {
            var rnd = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next();
            }
        }

        public void StackTestShort(IStack<int> stack, IStack<int> stack2)
        {
            Assert.IsNotNull(stack);
            Assert.IsTrue(stack.isEmpty());
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            Assert.IsFalse(stack.isEmpty());
            foreach (var value in stack)
            {
                stack2.push(value);
            }
            while (!stack.isEmpty() && !stack2.isEmpty())
            {
                Assert.AreEqual(stack.pop() + stack2.pop(), 6);
            }
            Assert.IsTrue(stack.isEmpty());
            Assert.IsTrue(stack2.isEmpty());
        }
        public void StackTestRandom(IStack<int> stack)
        {
            Assert.IsNotNull(stack);
            Assert.IsTrue(stack.isEmpty());
            foreach (var value in A)
            {
                stack.push(value);
                Assert.IsFalse(stack.isEmpty());
            }
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(stack.pop(), A[A.Length - i - 1]);
            }
            Assert.IsTrue(stack.isEmpty());
        }
    }
}
