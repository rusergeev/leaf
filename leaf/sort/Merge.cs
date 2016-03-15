using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SegmentIntersections
{
    public static class Merge
    {
        const int CUTOFF = 7;

        public static void sort(int[] a)
        {
            int[] aux = new int[a.Length];
            sort(a, aux, 0, a.Length - 1);
        }

        private static void sort(int[] a, IList<int> aux, int lo, int hi)
        {
            if (hi <= lo + CUTOFF - 1)
            {
                Insertion.sort(a, lo, hi);
                return;
            }

            int mid = lo + (hi - lo) / 2;
            Parallel.Invoke(() => sort(a, aux, lo, mid), () => sort(a, aux, mid + 1, hi));
            if (a[mid + 1] >= a[mid]) return;
            merge(a, aux, lo, mid, hi);
        }

        public static void sortbottomup(int[] a)
        {
            int N = a.Length;
            int[] aux = new int[N];
            for (int sz = 1; sz < N; sz = sz + sz)
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                    merge(a, aux, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
        }

        private static void merge(IList<int> a, IList<int> aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
                aux[k] = a[k];
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (aux[j] < aux[i]) a[k] = aux[j++];
                else a[k] = aux[i++];
            }
        }
    }
}