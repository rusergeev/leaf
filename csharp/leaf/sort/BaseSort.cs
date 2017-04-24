using System;

namespace leaf
{
    public abstract class BaseSort<Key> where Key: IComparable
    {
        protected static bool less(Key[] a, int i, int j) { return a[i].CompareTo(a[j]) < 0; }
        protected static void exch(Key[] a, int i, int j) { Key t = a[i]; a[i] = a[j]; a[j] = t; }
    }
}
