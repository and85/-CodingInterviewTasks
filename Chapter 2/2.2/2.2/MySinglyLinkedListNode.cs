using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public class MySinglyLinkedListNode<T>
    {
        public MySinglyLinkedListNode<T> Next {get;set;}
        public T Value { get; set; }
    }
}
