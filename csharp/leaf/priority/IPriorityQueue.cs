namespace leaf.priority
{
    interface IPriorityQueue<Key>
    {
        void Insert(Key v); //insert a key into the priority queue
        Key DelTop(); //return and remove the largest key
        bool IsEmpty(); // is the priority queue empty?
        Key Top(); // return the largest key
        int Size(); // number of entries in the priority queue
    }
}
