using System.Collections.Generic;
using LinkedListsProject.Interfaces;

namespace LinkedListsProject
{
    public class HistoryLinkedList<T> : LinkedList<T>, IHistory
    {
        private readonly LinkedList<T> _list;
        private List<T> DeletedElements { get; set; }

        public int DeletedLength { get => DeletedElements.Count; }
        
        public HistoryLinkedList() {
            _list = new LinkedList<T>();
            DeletedElements = new List<T>();
        }

        public new void Add(T element){
            _list.Add(element);
        }

        public new T RemoveAt(int index){
            var deletedElement = _list.RemoveAt(index);
            DeletedElements.Add(deletedElement);
            return deletedElement;
        }

        public void ClearDeleted() {
            DeletedElements = new List<T>();
        }

         public override string ToString(){
            return _list.ToString();
        }
    }
}