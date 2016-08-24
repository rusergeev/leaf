using System.Collections.Generic;

namespace leaf.graph
{
    public interface IGraph: ICountable
    {
        /// <summary>
        /// Adds an edge
        /// </summary>
        /// <param name="v"> from vertex</param>
        /// <param name="w"> to to vertex</param>
        void AddEdge(int v, int w);
        /// <summary>
        /// Reacheable (adjacent) vertecies
        /// </summary>
        /// <param name="v">from vertex</param>
        /// <returns> adjacent vertecies</returns>
        IEnumerable<int> Adj(int v);
    }
}