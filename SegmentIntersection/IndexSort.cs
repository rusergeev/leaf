using System;
using leaf;

namespace SegmentIntersection
{
    public class IndexSort<Key> : BaseSort<Key> where Key : IComparable
    {
        public static int[] SortIndex(Key[] a)
        {
            int N = a.Length;
            int[] index = new int[N];
            for (int i = 0; i < N; i++) index[i] = i;
            int[] aux = new int[N];
            for (int sz = 1; sz < N; sz = sz + sz)
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                    merge(a, index, aux, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
            return index;
        }
        private static void merge(Key[] a, int[] index, int[] aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
                aux[k] = index[k];
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) index[k] = aux[j++];
                else if (j > hi) index[k] = aux[i++];
                else if (less(a, aux[j], aux[i])) index[k] = aux[j++];
                else index[k] = aux[i++];
            }

        }
    }
}