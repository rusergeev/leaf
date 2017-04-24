using Microsoft.VisualStudio.TestTools.UnitTesting;
using leafTests.union;

namespace leaf.union.Tests
{
    [TestClass]
    public class QuickUnionUFTests
    {
        [TestMethod]
        public void FindTest()
        {
            IFindTest.FindTest(new QuickUnionUF(10));
        }

    }
}