using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SetOfStacks<T>
    {
        private int _threshold;
        private int _counter;

        private List<StackNode<T>> _stacks = new List<StackNode<T>>();

        public SetOfStacks(int threshold)
        {
            _threshold = threshold;
        }

        public void Push(T item)
        {
            if (_counter < _threshold && _stacks.Count > 0)
            {
                int currentStackIndex = _stacks.Count-1;
                _stacks[currentStackIndex].Value[_counter++] = item;
            }
            else
            {
                _counter = 0;
                AddNewStack(item);
            }
        }

        private void AddNewStack(T item)
        {
            var node = new StackNode<T>();
            node.Value = new T[_threshold];
            node.Value[_counter++] = item;

            _stacks.Add(node);
        }

        public T Pop()
        {
            if (_stacks.Count == 0) 
                throw new ArgumentException("Can't take elements from an empty stack");
            
            if (_counter == 0)
            {
                _stacks.RemoveAt(_stacks.Count - 1);
                _counter = _threshold;
            }

            T result = _stacks[_stacks.Count - 1].Value[--_counter];
            return result;
        }

        public T PopAt(int index)
        {
            int stackIndex = index / _threshold;
            int elemendIndex = index % _threshold;

            T result = _stacks[stackIndex].Value[elemendIndex];
            _stacks[stackIndex].Value[elemendIndex] = default(T);

            return result;
        }
    }
}
