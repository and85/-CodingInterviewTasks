using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class StackWithSharedArray<T>
    {
        private T[] _array;
        private int _indexShift;
        int stackTop;

        public StackWithSharedArray(T[] array, int indexShift)
        {
            _array = array;
            _indexShift = indexShift;
        }

        public void Push(T item)
        {
            _array[stackTop + _indexShift] = item;
            stackTop = stackTop + 3;
        }

        public T Pop()
        {
            stackTop = stackTop - 3;

            return _array[stackTop + _indexShift];
        }
    }
}
