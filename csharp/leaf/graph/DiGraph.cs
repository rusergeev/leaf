using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace leaf.graph
{
    public class DiGraph : IGraph
    {
        private readonly Collection<int>[] adj;
        /// <summary>
        /// Graph condtructor
        /// </summary>
        /// <param name="V">Number of vertecies</param>
        public DiGraph(int V)
        {
            Count = V;
            adj = new Collection<int>[V];
            for (int v = 0; v < V; v++)
                adj[v] = new Collection<int>();
        }
        /// <summary>
        /// Adds an edge
        /// </summary>
        /// <param name="v"> from vertex</param>
        /// <param name="w"> to to vertex</param>
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }
        /// <summary>
        /// Reacheable (adjacent) vertecies
        /// </summary>
        /// <param name="v">from vertex</param>
        /// <returns> adjacent vertecies</returns>
        public IEnumerable<int> Adj(int v)
        {
            return adj[v];
        }
        /// <summary>
        /// <returns> Number ov vertecies </returns>
        /// </summary>
        public int Count { get; }
    }
}
