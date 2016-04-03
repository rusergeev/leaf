using System.Collections.Generic;

namespace leaf.stack
{
    interface IStack<T>: IEnumerable<T>
    {
        bool isEmpty();
        void push(T item);
        T pop();
    }
}