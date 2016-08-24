namespace leaf.graph
{
    public class DepthFirstSearch
    {
        private readonly bool[] marked;
        /// <summary>
        /// Perform DFS on a graph from specific vertex
        /// </summary>
        /// <param name="G"> a graph</param>
        /// <param name="s"> starting vertex</param>
        public DepthFirstSearch(IGraph G, int s)
        {
            marked = new bool[G.Count];
            Dfs(G, s);
        }
        private void Dfs(IGraph G, int v)
        {
            marked[v] = true;
            foreach(var w in G.Adj(v))
                if (!marked[w])
                { Dfs(G, w);}
        }
        /// <summary>
        /// Check if specified vertex visited
        /// </summary>
        /// <param name="v"> the vertex</param>
        /// <returns> true if it was visited</returns>
        public bool Visited(int v)
        { return marked[v]; }
    }
}