using Microsoft.VisualStudio.TestTools.UnitTesting;
using leafTests.union;

namespace leaf.union.Tests
{
    [TestClass]
    public class QuickFindUFTests
    {
        [TestMethod]
        public void FindTest()
        {
            IFindTest.FindTest(new QuickFindUF(10));
        }

    }
}