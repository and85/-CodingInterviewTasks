using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsApplication
{
    public class MySinglyLinkedList<T> : ICollection<T>
    {
        public MySinglyLinkedListNode<T> First { get; set; }
        public MySinglyLinkedListNode<T> Last { get; set; }

        /// <summary>
        /// O(1) time complexity
        /// </summary>
        public void Add(T item)
        {
            var node = new MySinglyLinkedListNode<T>();
            node.Value = item;

            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            foreach (var node in this)
            {
                if (node.Equals(item))
                    return true;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            // O(1) possible only if we know exactly a position of the element we want to delete, otherwise it takes O(n)
            // this method won't delete duplicates
            var currentNode = First;

            while (currentNode != null)
            {
                if (currentNode.Next.Value.Equals(item))
                {
                    // delete the next node if this a node we want to delete
                    currentNode.Next = currentNode.Next.Next;
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()   
        {
            var currentNode = First;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
