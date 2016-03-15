using System.Collections.Generic;

namespace SegmentIntersections.queue
{
    public interface IQueue<T> : IEnumerable<T>
    {
        bool isEmpty();
        void enqueue(T item);
        T dequeue();
    }
}