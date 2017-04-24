using System.Collections;
using System.Collections.Generic;

namespace leaf.stack
{
    public class LinkedStack<T>:IStack<T>
    {
        private Node first;

        private class Node
        {
            public T item;
            public Node next;
        }

        public bool isEmpty()
        {
            return first == null;
        }

        public void push(T item)
        {
            Node oldfirst = first;
            first = new Node
            {
                item = item,
                next = oldfirst
            };
        }

        public T pop()
        {
            T item = first.item;
            first = first.next;
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
