using leaf.union;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leafTests.union
{
    class IFindTest
    {
        public static void FindTest(IUnionFind uf)
        {
            Assert.IsNotNull(uf);
            uf.Union(0, 1);
            uf.Union(2, 3);
            Assert.IsTrue(uf.Connected(0, 1));
            Assert.IsTrue(uf.Connected(2, 3));
            Assert.IsFalse(uf.Connected(0, 2));
            Assert.IsFalse(uf.Connected(0, 3));
            Assert.IsFalse(uf.Connected(1, 2));
            Assert.IsFalse(uf.Connected(1, 3));
            uf.Union(0, 3);
            Assert.IsTrue(uf.Connected(0, 2));
            Assert.IsTrue(uf.Connected(0, 3));
            Assert.IsTrue(uf.Connected(1, 2));
            Assert.IsTrue(uf.Connected(1, 3));
            Assert.IsFalse(uf.Connected(5, 1));
            Assert.IsFalse(uf.Connected(5, 2));
            Assert.IsFalse(uf.Connected(5, 3));
            Assert.IsFalse(uf.Connected(5, 4));
            uf.Union(5, 0);
            Assert.IsTrue(uf.Connected(5, 0));
            Assert.IsTrue(uf.Connected(5, 1));
            Assert.IsTrue(uf.Connected(5, 2));
            Assert.IsTrue(uf.Connected(5, 3));
            Assert.IsFalse(uf.Connected(5, 4));
        }
    }
}
