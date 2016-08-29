using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*
    In the classic problem of the Towers of Hanoi, 
     * you have 3 rods and N disks of different sizes which can slide onto any tower   
     * The puzzle starts with disks sorted in ascending order of size from top to bottom 
     * (e g , each disk sits on top of an even larger one)  
     * You have the following constraints: 
     * (A) Only one disk can be moved at a time 
     * (B) A disk is slid off the top of one rod onto the next rod 
     * (C) A disk can only be placed on top of a larger disk 
     * Write a program to move the disks from the first rod to the last using Stacks 
    
    */
    class Program
    {
        static void Main(string[] args)
        {
            var stack1 = new Stack();
            stack1.Push(3);
            stack1.Push(2);
            stack1.Push(1);

            var stack2 = new Stack();
            var stack3 = new Stack();

            HanoiTower(stack1, stack2, stack3);
#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        private static void PrintStack(Stack stack)
        {
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("-----------------------------------------");
        }

        private static void HanoiTower(Stack stack1, Stack stack2, Stack stack3)
        {
            int stack1Top = GetStackTop(stack1);
            int stack2Top = GetStackTop(stack2);
            int stack3Top = GetStackTop(stack2);


        }

        private static int GetStackTop(Stack stack)
        {
            int result = int.MaxValue;

            if (stack.Count > 0)
            {
                result = (int)stack.Peek();
            }

            return result;
        }
    }
}

