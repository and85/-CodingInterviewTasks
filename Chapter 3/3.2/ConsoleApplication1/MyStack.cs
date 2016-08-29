using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyStack<T>
    {
        LinkedListNode<T> First;

        public void Push(T item)
        {
            var node = new LinkedListNode<T>();
            node.Next = First;
            node.Value = item;

            if (First == null)
            {
                node.Min = node.Value;
            }
            else
            {
                if (Comparer<T>.Default.Compare(node.Value, First.Min) < 0)
                {
                    node.Min = node.Value;
                }
                else
                {
                    node.Min = First.Min;
                }
            }

            First = node;
        }

        //  Pop should remove an elemend from the stack and change Min if required
        public T Pop()
        {
            T result = First.Value;

            First = First.Next;

            return result;
        }

        public T GetMin()
        {
            if (First == null)
            {
                throw new Exception("Can't return Min for an empty stack");
            }

            return First.Min;
        }
    }
}
