using leafTests.stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leaf.stack.Tests
{
    [TestClass]
    public class LinkedStackTests
    {
        [TestMethod]
        public void StackTestShort()
        {
            var tester = new IStackTests();
            tester.StackTestShort(new LinkedStack<int>(), new LinkedStack<int>());
        }
        [TestMethod]
        public void StackTestRandom()
        {
            var tester = new IStackTests();
            tester.StackTestRandom(new LinkedStack<int>());
        }
    }
}