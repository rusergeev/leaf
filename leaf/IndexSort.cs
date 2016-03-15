using System;
using System.Collections.Generic;

namespace SegmentIntersections
{
    public static class IndexSort
    {
        public static IList<int> SortIndex(this IReadOnlyList<double> a)
        {
            int N = a.Count;
            int[] index = new int[N];
            for (int i = 0; i < N; i++) index[i] = i;
            int[] aux = new int[N];
            for (int sz = 1; sz < N; sz = sz + sz)
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                    merge(a, index, aux, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
            return index;
        }
        private static void merge(IReadOnlyList<double> a, IList<int> index, IList<int> aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
                aux[k] = index[k];
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) index[k] = aux[j++];
                else if (j > hi) index[k] = aux[i++];
                else if (a[aux[j]] < a[aux[i]]) index[k] = aux[j++];
                else index[k] = aux[i++];
            }

        }
    }
}