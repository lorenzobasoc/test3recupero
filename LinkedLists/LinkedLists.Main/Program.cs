using System;

namespace LinkedListsProject.Main
{
    class Program
    {
        static void Main() {
            var ll = new HistoryLinkedList<int>();
            ll.Add(1);
            ll.Add(12);
            ll.Add(9);
            ll.Add(66);
            ll.Add(126);
            Console.WriteLine(ll.ToString());
            Console.WriteLine("Rimosso il coso in posiz 2");
            ll.RemoveAt(2);
            Console.WriteLine(ll.ToString());
            Console.WriteLine("Aggiunti il 1234 e 90");
            ll.Add(1234);
            ll.Add(90);
            Console.WriteLine(ll.ToString());
            Console.WriteLine("Rimossi in pos 0 e 3");
            Console.WriteLine("E' stato rimosso l'elemento" + " " + ll.RemoveAt(0));
            Console.WriteLine("E' stato rimosso l'elemento" + " " + ll.RemoveAt(3));
            Console.WriteLine(ll.ToString());
            Console.WriteLine(ll.DeletedLength);
            ll.ClearDeleted();
            Console.WriteLine(ll.DeletedLength);
        }
    }
}
