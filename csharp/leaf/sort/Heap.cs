using System;

namespace leaf
{
    public class Heap<Key> :BaseSort<Key> where Key: IComparable
    {
        public static void sort(Key[] a)
        {
            int N = a.Length-1;
            for (int k = N / 2; k >= 0; k--)
                sink(a, k, N);
            while (N > 0)
            {
                exch(a, 0, N);
                sink(a, 0, --N);
            }
        }

        private static void sink(Key[] a, int k, int N)
        {
            while (2*k + 1 <= N)
            {
                int j = 2*k + 1;
                if (j < N && less(a, j, j + 1)) j++;
                if (!less(a, k, j)) break;
                exch(a, k, j);
                k = j;
            }
        }
    }
}
