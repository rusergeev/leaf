using System.Collections;
using System.Collections.Generic;

namespace leaf.stack
{
    public class FixedCapacityStack<T> : IStack<T>
    {
        private readonly T[] s;
        private int N;

        public FixedCapacityStack(int capacity)
        { s = new T[capacity]; }

        public bool isEmpty()
        { return N == 0; }

        public void push(T item)
        { s[N++] = item; }

        public T pop()
        { return s[--N]; }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = N; i > 0; i++)
            {
                yield return s[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}