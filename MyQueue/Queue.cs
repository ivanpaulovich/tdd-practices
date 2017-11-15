using System;

namespace FxPro
{
    public class Queue<T> : IGenericQueue<T>
    {
        private T[] _data;
        private int count;

        public Queue(int maxSize)
        {
            this._data = new T[maxSize];
        }

        public void Enqueue(T item)
        {
            if (count + 1 > this._data.Length)
                throw new QueueIsFullException();

            this._data[count] = item;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new QueueIsEmptyException();

            T item = this._data[count - 1];
            count--;
            return item;
        }
    }
}
