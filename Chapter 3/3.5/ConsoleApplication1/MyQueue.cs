using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyQueue<T>
    {
        Stack<T> _stack1 = new Stack<T>();
        Stack<T> _stack2 = new Stack<T>();

        public void Enqueue(T item)
        {
            _stack1.Push(item);
        }

        public T Dequeue()
        {
            if (_stack2.Count != 0)
                return _stack2.Pop();

            while (_stack1.Count() != 0)
                _stack2.Push(_stack1.Pop());

            return _stack2.Pop();
        }
    }
}
