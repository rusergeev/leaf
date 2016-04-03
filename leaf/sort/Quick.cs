using System;
using System.Threading.Tasks;

namespace SegmentIntersections
{
    public static class Quick
    {
        const int CUTOFF = 7;
        public static void sort(int[] a)
        {
            shuffle(a);
            sort(a, 0, a.Length-1);
        }

        private static void sort(int[] a, int lo, int hi)
        {
            if (hi <= lo + CUTOFF - 1)
            {
                Insertion.sort(a, lo, hi);
                return;
            }

            int lt = lo, gt = hi;
            int v = a[lo];
            int i = lo;
            while (i <= gt)
            {
                int cmp = a[i].CompareTo(v);
                if (cmp < 0) Just.swap(a, lt++, i++);
                else if (cmp > 0) Just.swap(a, i, gt--);
                else i++;
            }
            Parallel.Invoke(() => sort(a, lo, lt - 1), () => sort(a, gt + 1, hi));
        }

        public static void shuffle<T>(T[] a)
        {
            int N = a.Length;
            var rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                int r = rnd.Next(i, N-1);
                Just.swap(a, i, r);
            }
        }
    }
}
