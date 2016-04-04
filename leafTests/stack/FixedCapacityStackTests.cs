using Microsoft.VisualStudio.TestTools.UnitTesting;
using leafTests.stack;

namespace leaf.stack.Tests
{
    [TestClass]
    public class FixedCapacityStackTests
    {
        [TestMethod]
        public void StackTestShort()
        {
            var tester = new IStackTests();
            tester.StackTestShort(new FixedCapacityStack<int>(10000), new FixedCapacityStack<int>(10000));
        }
        [TestMethod]
        public void StackTestRandom()
        {
            var tester = new IStackTests();
            tester.StackTestRandom(new FixedCapacityStack<int>(10000));
        }
    }
}