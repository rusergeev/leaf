using Microsoft.VisualStudio.TestTools.UnitTesting;
using leafTests.union;

namespace leaf.union.Tests
{
    [TestClass]
    public class FindTests
    {
        [TestMethod]
        public void FindTest()
        {
            IFindTest.FindTest( new WeightedUnionFind(10));
        }
    }
}