using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MySinglyLinkedList<T>: IEnumerable<T>
    {
        public MySinglyLinkedListNode<T> First { get; set; }
        public MySinglyLinkedListNode<T> Last { get; set; }

        /// <summary>
        /// O(1) time complexity
        /// </summary>
        public void Add(MySinglyLinkedListNode<T> node)
        {
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

        public void Remove(MySinglyLinkedListNode<T> node)
        {
             if (node == null || node.Next == null) 
             {
                 throw new ArgumentException("Can't delete a tail node");
             }

            var next = node.Next;
            node.Value = next.Value;
            node.Next = next.Next;
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
