using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsApplication
{
    // this is a bad implementation because Add operation requires O(n) steps
    public class MySinglyLinkedListBadImplementation<T> : ICollection<T>
    {
        MySinglyLinkedListNode<T> _root = null;

        public MySinglyLinkedListNode<T> LastNode
        {
            get
            {
                MySinglyLinkedListNode<T> current = _root;

                if (current == null)
                    return null;

                while (current.Next != null)
                    current = current.Next;

                return current;
            }
        }

        public void Add(T item)
        {
            MySinglyLinkedListNode<T> node = new MySinglyLinkedListNode<T>();
            node.Value = item;
            node.Next = null;

            if (_root == null)
                _root = node;
            else
                LastNode.Next = node;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
