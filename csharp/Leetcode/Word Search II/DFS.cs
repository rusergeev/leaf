using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using leaf.trie;

namespace Leetcode.Word_Search_II
{
    public class DFS
    {
        private readonly bool[] visited;
        private readonly MatrixAsGraph<char> Graph;
        private readonly Trie Trie;
        public DFS(MatrixAsGraph<char> graph, Trie trie)
        {
            visited = new bool[graph.Count];
            this.Graph = graph;
            this.Trie = trie;
        }

        public IEnumerable<string> TraverseFrom(int v)
        {
            Debug.WriteLine(" ");
            Debug.WriteLine($"{v % 6}-{v / 6}:");
            for (int i = 0; i< visited.Length; i++)
            {
                visited[i] = false;
            }
            var c = Graph.Value(v);
            return Trie.Contains(c)? Visit(v, Trie.GetNext(c)) : Enumerable.Empty<string>();
        }

        private IEnumerable<string> Visit(int v, Trie trie)
        {
            Debug.Write($"{Graph.Value(v)} ");
            visited[v] = true;
            if (trie.IsWord())
            {
                Debug.Write($"[{trie.GetWord()}] ");
                yield return trie.GetWord();
            }

            foreach (var w in Graph.Next(v))
            {
                var c = Graph.Value(w);
                if (!visited[w] && trie.Contains(c))
                {
                    Debug.Write("{ ");
                    foreach (var word in Visit(w, trie.GetNext(c)))
                        yield return word;
                    Debug.Write("} ");
                }
            }
        }
    }
}