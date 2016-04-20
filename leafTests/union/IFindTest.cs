using leaf.union;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leafTests.union
{
    class IFindTest
    {
        public static void FindTest(IUnionFind uf)
        {
            Assert.IsNotNull(uf);
            uf.union(0, 1);
            uf.union(2, 3);
            Assert.IsTrue(uf.connected(0, 1));
            Assert.IsTrue(uf.connected(2, 3));
            Assert.IsFalse(uf.connected(0, 2));
            Assert.IsFalse(uf.connected(0, 3));
            Assert.IsFalse(uf.connected(1, 2));
            Assert.IsFalse(uf.connected(1, 3));
            uf.union(0, 3);
            Assert.IsTrue(uf.connected(0, 2));
            Assert.IsTrue(uf.connected(0, 3));
            Assert.IsTrue(uf.connected(1, 2));
            Assert.IsTrue(uf.connected(1, 3));
            Assert.IsFalse(uf.connected(5, 1));
            Assert.IsFalse(uf.connected(5, 2));
            Assert.IsFalse(uf.connected(5, 3));
            Assert.IsFalse(uf.connected(5, 4));
            uf.union(5, 0);
            Assert.IsTrue(uf.connected(5, 0));
            Assert.IsTrue(uf.connected(5, 1));
            Assert.IsTrue(uf.connected(5, 2));
            Assert.IsTrue(uf.connected(5, 3));
            Assert.IsFalse(uf.connected(5, 4));
        }
    }
}
