using LinkedListsProject.Exceptions;
using LinkedListsProject.Interfaces;

namespace LinkedListsProject
{
    public class LinkedList<T> : IDimension, ILinkedList<T>
    {
        public int Length { get; set; }
        public Node<T> Head { get; set;}

        public void Add(T element){
            Length++;
            var newNode = new Node<T>(element){
                Next = default,
                Index = Length - 1,
            };
            if (Head == null) {
                Head = newNode;
            } else {
                var last = Head;
                while (last.Next != default) {
                    last = last.Next;
                }
                last.Next = newNode;
            }
        }

        public T RemoveAt(int index){
            Length--;
           if (Head == null || index < 0) {
                throw new NoElementInThatIndexException("No element found in that index.");
            } else if (index == 0){
                var ris = Head;
                Head = Head.Next;
                var last = Head;
                while (last != default){
                    last.Index--;
                    last = last.Next;
                }
                return ris.Element;
            } else {
                var last = Head;
                while (last.Next.Index != index){
                    last = last.Next;
                }
                var nextNode = last;
                var ris = last;
                while (nextNode.Index != index + 1){
                    nextNode = nextNode.Next;
                }
                last.Next = nextNode;
                while (nextNode != default){
                    nextNode.Index--;
                    nextNode = nextNode.Next;
                }
                return ris.Element;
            }
        }

        public override string ToString(){
            var ris = "";
            var currNode = Head;
            while (currNode != null) {
                ris += $"Value: {currNode.Element}, Index: {currNode.Index}\n";
                currNode = currNode.Next;
            }
            return ris;
        }
    }
}