using Microsoft.VisualStudio.TestTools.UnitTesting;
using leaf.trie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaf.trie.Tests
{
    [TestClass()]
    public class TrieTests
    {
        [TestMethod()]
        public void TrieTest()
        {
            string[] words = { "aab","bsdsf","rwerfd","aaaaa", "aaaasd", "bsdss", "bsdsfs" };

            var trie = new Trie();
            Assert.IsNotNull(trie);

            trie.Add(words);

            foreach (var word in words)
            {
                var cur = trie;
                foreach (var c in word)
                {
                    cur = cur.GetNext(c);
                    Assert.IsNotNull(cur);
                }
                Assert.IsTrue(cur.IsWord());
                Assert.AreEqual(cur.GetWord(), word);
            }
        }
    }
}