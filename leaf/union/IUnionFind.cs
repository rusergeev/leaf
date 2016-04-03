namespace leaf.union
{
    interface IUnionFind
    {
        bool connected(int p, int q);
        void union(int p, int q);
    }
}