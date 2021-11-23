namespace LinkedListsProject
{
    public class Node<T>
    {
        public T Element { get; set; }
        public Node<T> Next { get; set; }
        public int Index { get; set; }

        public Node(T first){
            Element = first;
        }
    }
}