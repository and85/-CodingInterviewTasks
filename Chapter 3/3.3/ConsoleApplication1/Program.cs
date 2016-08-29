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
        Imagine a (literal) stack of plates   If the stack gets too high, it might topple   
         * Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold   
         * Implement a data structure SetOfStacks that mimics this   SetOfStacks should be composed of several stacks, 
         * and should create a new stack once the previous one exceeds capacity   SetOfStacks push() and SetOfStacks pop() 
         * should behave identically to a single stack (that is, pop() should return the same values as it would if 
         * there were just a single stack) 
         * FOLLOW UP Implement a function popAt(int index) which performs a pop operation on a specific sub-stack 
        */
        static void Main(string[] args)
        {
            var stack = new SetOfStacks<int>(2);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            Console.WriteLine(stack.PopAt(4));
            

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }
    }
}
