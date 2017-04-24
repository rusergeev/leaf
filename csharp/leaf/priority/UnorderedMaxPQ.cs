using System;

namespace leaf.priority
{
    public class UnorderedMaxPQ<Key> : IPriorityQueue<Key> where Key : IComparable
    {
        private readonly Key[] pq; // pq[i] = i-th element on pq   
        private int N; // number of elements on pq

        public UnorderedMaxPQ(int capacity)
        {
            pq = new Key[capacity];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public Key Top()
        {
            return pq[MaxOfIndex()];
        }

        public int Size()
        {
            return N;
        }

        public void Insert(Key x)
        {
            pq[N++] = x;
        }

        public Key DelTop()
        {
            var max = MaxOfIndex();
            Exch(max, N - 1);
            return pq[--N];
        }

        private int MaxOfIndex()
        {
            int max = 0;
            for (int i = 1; i < N; i++)
                if (less(max, i))
                    max = i;
            return max;
        }

        private void Exch(int i, int j)
        {
            var t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }

        private bool less(int i, int j)
        {
            return pq[i].CompareTo(pq[j]) < 0;
        }
    }
}
