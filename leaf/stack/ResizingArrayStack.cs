using System.Collections;
using System.Collections.Generic;

namespace leaf.stack
{
    public class ResizingArrayStack<T> : IStack<T>
    {
        private T[] s;
        private int N;

        public ResizingArrayStack()
        {
            s = new T[1];
        }

        public bool isEmpty()
        { return N == 0; }

        public void push(T item)
        {
            if (N == s.Length) resize(2 * s.Length);
            s[N++] = item;
        }

        public T pop()
        {
            T item = s[--N];
            s[N] = default(T);
            if (N > 0 && N == s.Length / 4) resize(s.Length / 2);
            return item;
        }

        private void resize(int capacity)
        {
            T[] copy = new T[capacity];
            for (int i = 0; i < N; i++)
                copy[i] = s[i];
            s = copy;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = N-1; i >= 0; i--)
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