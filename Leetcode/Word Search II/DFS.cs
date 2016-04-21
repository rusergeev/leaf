using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using leaf.trie;

namespace Leetcode.Word_Search_II
{
    public class DFS
    {
        private readonly bool[] visited;
        private readonly MatrixAsGraph<char> graph;
        private readonly Trie trie;
        public DFS(MatrixAsGraph<char> graph, Trie trie)
        {
            visited = new bool[graph.Count];
            this.graph = graph;
            this.trie = trie;
        }

        public IEnumerable<string> TraverseFrom(int v)
        {
            Debug.WriteLine(" ");
            for (int i = 0; i< visited.Length; i++)
            {
                visited[i] = false;
            }
            return Visit(v, trie);
        }

        private IEnumerable<string> Visit(int v, Trie node)
        {
            Debug.Write($"{v % 3}-{v / 3}({graph.Value(v)}) ");
            visited[v] = true;
            if (node.IsWord())
            {
                Debug.Write($"[{node.GetWord()}] ");
                yield return node.GetWord();
            }

            var next = node.GetNext(graph.Value(v));
            if (next == null) yield break;

            foreach (var w in graph.Next(v))
            {

                if (!visited[w])
                {
                    Debug.Write("{ ");
                    foreach (var word in Visit(w, next))
                        yield return word;
                    Debug.Write("} ");
                }
            }
        }
    }
}