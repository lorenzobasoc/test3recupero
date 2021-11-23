using LinkedListsProject;
using LinkedListsProject.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedLists.Test
{
    [TestClass]
    public class LinkedListTests
    {

        [TestMethod] public void New_LinkedList_is_empty() {
            var ll = new LinkedList<string>();
            Assert.AreEqual(0, ll.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(NoElementInThatIndexException))]
        public void Remove_elements_on_empty_list_throws_exc() {
            var ll = new LinkedList<string>();
            ll.RemoveAt(1);
        }

        [TestMethod] public void Add_elements_increases_Length() {
            var ll = new LinkedList<string>();
            ll.Add("first");
            ll.Add("second");
            ll.Add("third");
            Assert.AreEqual(3, ll.Length);
        }

        [TestMethod] public void Remove_decreases_Length() {
            var ll = new LinkedList<string>();
            ll.Add("1");
            var _ = ll.RemoveAt(0);
            Assert.AreEqual(0, ll.Length);
        }

        [TestMethod] public void Elements_are_added_in_the_same_order() {
            var l = new LinkedList<string>();
            l.Add("1");
            l.Add("2");
            l.Add("3");
            Assert.AreEqual("1", l.RemoveAt(0));
            Assert.AreEqual("2", l.RemoveAt(1));
            Assert.AreEqual("3", l.RemoveAt(2));
        }

        [TestMethod] public void Can_add_and_Remove_multiple_times() {
            var ll = new LinkedList<string>();
            ll.Add("1");
            var i1 = ll.RemoveAt(0);
            ll.Add("2");
            ll.Add("3");
            ll.Add("4");
            ll.Add("5");
            var i2 = ll.RemoveAt(1);
            var i3 = ll.RemoveAt(2);
            Assert.AreEqual("1", i1);
            Assert.AreEqual("3", i2);
            Assert.AreEqual("4", i3);
            Assert.AreEqual(2, ll.Length);
        }

        [TestMethod] public void HistoryLinkedList_remove_elements_increase_DeletedLength(){
            var hll = new HistoryLinkedList<int>();
            hll.Add(1);
            hll.RemoveAt(0);
            Assert.AreEqual(1, hll.DeletedLength);
        }

        [TestMethod] public void HistoryLinkedList_ClearDeleted_makes_DeletedLength_zero(){
            var hll = new HistoryLinkedList<int>();
            hll.Add(1);
            hll.RemoveAt(0);
            hll.ClearDeleted();
            Assert.AreEqual(0, hll.DeletedLength);
        }
    }
}
