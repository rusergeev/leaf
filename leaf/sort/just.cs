using System.Collections.Generic;

namespace leaf
{
    public static class Just
    {
        public static void swap<T>(IList<T> a, int i1, int i2)
        {
            var t = a[i1];
            a[i1] = a[i2];
            a[i2] = t;
        }
    }
}