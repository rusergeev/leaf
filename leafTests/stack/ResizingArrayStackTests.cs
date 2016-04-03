using leafTests.stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leaf.stack.Tests
{
    [TestClass()]
    public class ResizingArrayStackTests
    {
        [TestMethod]
        public void StackTestShort()
        {
            var tester = new IStackTests();
            tester.StackTestShort(new ResizingArrayStack<int>(), new ResizingArrayStack<int>());
        }
        [TestMethod]
        public void StackTestRandom()
        {
            var tester = new IStackTests();
            tester.StackTestRandom(new ResizingArrayStack<int>());
        }
    }
}