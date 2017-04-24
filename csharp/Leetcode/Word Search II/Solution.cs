using System.Collections.Generic;
using System.Linq;
using leaf.trie;

namespace Leetcode.Word_Search_II
{
    public class Solution
    {

        public IList<string> FindWords(char[,] board, string[] words)
        {
            var result = new HashSet<string>();
            var graph = new MatrixAsGraph<char>(board);
            var trie = new Trie();
            trie.Add(words);
            var dfs = new DFS(graph, trie);

            foreach (var v in graph)
                foreach (var word in dfs.TraverseFrom(v))
                    result.Add(word);
            return result.ToList();
        }
    }
}
