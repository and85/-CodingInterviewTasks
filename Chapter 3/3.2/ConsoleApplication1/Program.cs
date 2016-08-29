using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /*
        How would you design a stack which, in addition to push and pop, also has a function min which 
        returns the minimum element? Push, pop and min should all operate in O(1) time 
        */
        static void Main(string[] args)
        {
            var stack = new MyStack<int>();
            stack.Push(2);
            stack.Push(1);
            stack.Push(3);
            stack.Push(0);

            Console.WriteLine(stack.GetMin());
            stack.Pop();
            Console.WriteLine(stack.GetMin());
            stack.Pop();
            Console.WriteLine(stack.GetMin());
            stack.Pop();
            Console.WriteLine(stack.GetMin());
            
#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }
    }
}
