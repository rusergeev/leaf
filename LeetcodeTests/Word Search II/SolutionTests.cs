using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.Word_Search_II;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Word_Search_II.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void FindWordsTest()
        {
            char[,] matrix = { { 'c', 'a', 't' }, { 'a', 'c', 'e' }, { 'p', 'a', 'l' }, { 'o', 't', 'e' } };
            string[] words = { "cat", "pal", "cap", "ace", "lapa", "cam", "otac", "opal", "soplo", "solo", "wolok" };
            var sol = new Solution();
            var res = sol.FindWords(matrix, words);
            Assert.AreEqual(res.Count, 6);
        }
        [TestMethod]
        public void FindWordsTest2()
        {
            char[,] matrix = { { 'o','a','a','n'}, { 'e','t','a','e' },{ 'i','h','k','r' }, { 'i','f','l','v' } };
            string[] words = {"oath", "pea", "eat", "rain"};

            var sol = new Solution();
            var res = sol.FindWords(matrix, words);
            Assert.AreEqual(res.Count, 2);
        }
        [TestMethod]
        public void FindWordsTest3()
        {
            char[,] matrix = { { 'a', 'b'}, { 'c', 'd' } };
            string[] words = { "cdba", "pea", "eat", "rain" };

            var sol = new Solution();
            var res = sol.FindWords(matrix, words);
            Assert.AreEqual(res.Count, 1);
            Assert.AreEqual(res.First(), "cdba");
        }
    }
}