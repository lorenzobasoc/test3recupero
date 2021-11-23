namespace LinkedListsProject.Interfaces
{
    public interface ILinkedList<T>
    {
        void Add(T obj);

        T RemoveAt(int index);
    }
}