using System;

namespace leaf.priority
{
    public class MaxPQ<Key>: IPriorityQueue<Key> where Key: IComparable 
    {   
        private readonly Key[] pq;
        private int N;

        public MaxPQ(int capacity)
        {
            pq = new Key[capacity + 1];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Insert(Key v)
        {
            pq[++N] = v;
            swim(N);
        }

        public Key DelTop()
        {
            Key max = pq[1];
            exch(1, N--);
            sink(1);
            pq[N + 1] = default(Key);
            return max;
        }

        public Key Top()
        {
            return pq[1];
        }

        public int Size()
        {
            return N;
        }

        private void swim(int k)
        {
            while (k > 1 && less(k/2, k))
            {
                exch(k, k/2);
                k = k/2;
            }
        }

        private void sink(int k)
        {
            while (2*k <= N)
            {
                int j = 2*k;
                if (j < N && less(j, j + 1)) j++;
                if (!less(k, j)) break;
                exch(k, j);
                k = j;
            }
        }
        private bool less(int i, int j) { return pq[i].CompareTo(pq[j]) < 0; }
        private void exch(int i, int j) { Key t = pq[i]; pq[i] = pq[j]; pq[j] = t; }
    }
}
