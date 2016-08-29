using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class StackNode<T>
    {
        public StackNode<T> Next { get; set; }
        public T[] Value { get; set; }
    }
}
