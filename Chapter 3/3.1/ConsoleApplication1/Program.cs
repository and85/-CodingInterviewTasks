using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // Describe how you could use a single array to implement three stacks 
        static void Main(string[] args)
        {
            // when number of elements exceeds array size, it will fail
            int[] array = new int[20];
            var stack1 = new StackWithSharedArray<int>(array, 0);
            var stack2 = new StackWithSharedArray<int>(array, 1);
            var stack3 = new StackWithSharedArray<int>(array, 2);

            stack1.Push(0);
            stack2.Push(1);
            stack3.Push(2);

            stack1.Push(3);
            stack2.Push(4);
            stack3.Push(5);

            stack1.Push(6);
            stack2.Push(7);
            stack3.Push(8);

            stack1.Push(9);
            stack2.Push(10);
            stack3.Push(11);

            Console.WriteLine("Stack1");
            PrintPop(stack1);
            Console.WriteLine("Stack2");
            PrintPop(stack2);
            Console.WriteLine("Stack3");
            PrintPop(stack3);

            stack1.Push(111);
            Console.WriteLine(stack1.Pop());
#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        private static void PrintPop(StackWithSharedArray<int> stack)
        {
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}


