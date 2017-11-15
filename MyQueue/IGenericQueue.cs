namespace FxPro
{
    public interface IGenericQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
    }
}
