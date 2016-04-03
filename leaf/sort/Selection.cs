using System;

namespace leaf
{
    public class Selection<Key> : BaseSort<Key> where Key : IComparable
    {
        public static void sort(Key[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                    if (less(a, j, min))
                        min = j;
                exch(a, i, min);
            }
        }
    }
}