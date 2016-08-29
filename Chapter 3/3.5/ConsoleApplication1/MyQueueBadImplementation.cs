using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // Should implement FIFO algorithm
    public class MyQueueBadImplementation<T>
    {
        Stack<T> _stack1 = new Stack<T>();
        Stack<T> _stack2 = new Stack<T>();

        // to many moves between stacks
        public void Enqueue(T item)
        {
            if (_stack2.Count == 0)
            {
                _stack2.Push(item);
                return;
            }
            
            // move all elements from stack2 to stack1 to keep reverse order
            while (_stack2.Count != 0)
            {
                _stack1.Push(_stack2.Pop());
            }
            
            // move the last element to a bottom of stack2
            _stack2.Push(item);

            // move all elements from stack1 to stack2
            while (_stack1.Count != 0)
            {
                _stack2.Push(_stack1.Pop());
            }

        }

        public T Dequeue()
        {
            if (_stack2.Count == 0)
                throw new NullReferenceException("Nothing to return");

            return _stack2.Pop();
        }
    }
}
