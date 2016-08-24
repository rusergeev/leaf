namespace leaf.union
{
    public class WeightedUnionFind : IUnionFind
    {
        private readonly int[] id;
        private readonly int[] sz;
        public WeightedUnionFind(int N)
        {
            id = new int[N];
            sz = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }
        }
        private int Root(int i)
        {
            while (i != id[i])
            {
                id[i] = id[id[i]];
                i = id[i];
            }
            return i;
        }
        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }
        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            if (i == j) return;
            if (sz[i] < sz[j])  { id[i] = j; sz[j] += sz[i]; }
            else                { id[j] = i; sz[i] += sz[j]; }

        }
    }
}