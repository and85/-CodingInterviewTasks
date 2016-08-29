using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    // LinkedList based implementation, Push and Pop are O(1). Drawbacks comparing to array based implementation is increased memory usage
    public class MyStack<T>
    {
        LinkedListNode<T> First;
        
        public void Push(T item)
        {
            var node = new LinkedListNode<T>();
            node.Next = First;
            node.Value = item;

            First = node;
        }

        public T Pop()
        {
            T result = First.Value;

            First = First.Next;

            return result;
        }
    }
}
