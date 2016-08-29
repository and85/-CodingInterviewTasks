using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next;
        public T Value { get; set; }
        public T Min { get; set; }
    }
}
