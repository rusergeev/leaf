using System;

namespace leaf
{
    public class Insertion<Key>:BaseSort<Key> where Key: IComparable
    {
        public static void sort(Key[] a)
        {
            sort(a, 0, a.Length-1);
        }

        public static void sort(Key[] a, int lo, int hi)
        {
            for (int i = lo; i <= hi; i++)
                for (int j = i; j > lo; j--)
                    if (less(a, j, j - 1))
                        exch(a, j, j - 1);
                    else break;
        }
    }
}