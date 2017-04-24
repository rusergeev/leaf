namespace SegmentIntersection
{
    class IntSet
    {
        const int empty = -2;
        private int[] a;
        private int head =-1;
        public IntSet(int capacity)
        {
            a = new int[capacity];
            for(var i = 0 ; i < capacity; i++) a[i] = empty;
        }

        public void Add(int x)
        {
            if (a[x] == empty)
            {
                a[x] = head;
                head = x;
            }
        }
        public void Remove(int x)
        {
            if (a[x] != empty)
            {
                head = x;
                a[x] = empty;
            }
        }
    }
}