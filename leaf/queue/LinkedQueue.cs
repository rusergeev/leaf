using System.Collections;
using System.Collections.Generic;

namespace leaf.queue
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private Node first, last;

        private class Node
        {
            public T item;
            public Node next;
        }

        public bool isEmpty()
        { return first == null; }

        public void enqueue(T item)
        {
            Node oldlast = last;
            last = new Node
            {
                item = item,
                next = null
            };
            if (isEmpty()) first = last;
            else oldlast.next = last;
        }

        public T dequeue()
        {
            T item = first.item;
            first = first.next;
            if (isEmpty()) last = null;
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = first;
            while (current != null)
            {
                var item = current.item;
                current = current.next;
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
