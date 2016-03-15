namespace SegmentIntersections
{
    public class Selection
    {
        public static void sort(int[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                    if (a[j] < a[min])
                        min = j;
                Just.swap(a, i, min);
            }
        }
    }
}