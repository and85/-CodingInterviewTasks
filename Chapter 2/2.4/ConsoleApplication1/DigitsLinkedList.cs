using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DigitsLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void Add(int item)
        {
            var node = new Node();
            node.Value = item;

            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
    }
}
