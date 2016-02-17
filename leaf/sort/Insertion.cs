namespace leaf
{
    public static class Insertion
    {

        public static void sort(int[] a)
        {
            sort(a, 0, a.Length-1);
        }

        public static void sort(int[] a, int lo, int hi)
        {
            for (int i = lo; i <= hi; i++)
                for (int j = i; j > lo; j--)
                    if (a[j] < a[j - 1])
                        Just.swap(a, j, j - 1);
                    else break;
        }
    }
}