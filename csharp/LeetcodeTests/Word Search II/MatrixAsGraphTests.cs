using leaf.trie;
using Leetcode.Word_Search_II;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests.Word_Search_II
{
    [TestClass]
    public class MatrixAsGraphTests
    {
        [TestMethod]
        public void MatrixAsGraphEmptyTest()
        {
            char[,] empty1 = { };
            char[,] empty2 = { { } };
            char[,] empty3 = { { }, { } };
            var g1 = new MatrixAsGraph<char>(empty1);
            Assert.IsNotNull(g1);
            var g2 = new MatrixAsGraph<char>(empty2);
            Assert.IsNotNull(g2);
            var g3 = new MatrixAsGraph<char>(empty3);
            Assert.IsNotNull(g3);

        }
        [TestMethod]
        public void MatrixAsGraphTest()
        {
            char[,] matrix = { {'c','a','t'}, {'a','c','e'}, {'p', 'a', 'l'}, {'o','t','e'} };
            string[] words = {"cat", "pal", "cap", "ace", "lapa", "cam", "otac", "opal", "soplo", "solo", "wolok"};
            var graph = new MatrixAsGraph<char>(matrix);
            Assert.IsNotNull(graph);
            Assert.AreEqual(graph.Count, matrix.GetLength(0)*matrix.GetLength(1));

            var trie = new Trie();
            trie.Add(words);

            var dfs = new DFS(graph, trie);

            foreach (var v in graph)
            {
                dfs.TraverseFrom(v);
            }

        }

    }
}