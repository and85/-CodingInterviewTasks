using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // Implement a MyQueue class which implements a queue using two stacks 
        static void Main(string[] args)
        {
            var queue = new MyQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(6);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

#if DEBUG
            Console.WriteLine();
            Console.ReadLine();
#endif
        }
    }
}


