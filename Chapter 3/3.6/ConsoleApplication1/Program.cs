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
         *  Write a program to sort a stack in ascending order  
         *  You should not make any assumptions about how the stack is implemented  
         *  The following are the only functions that should be used to write this program: push | pop | peek | isEmpty 
         *  */
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(9);
            s.Push(5);
            s.Push(19);
            s.Push(2);

            Sort(s);
    
#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        public static Stack<int> Sort(Stack<int> s) 
        { 
            var r = new Stack<int>();   

            while ( s.Count > 0 ) 
            { 
                int tmp = s.Pop(); 
                
                while(r.Count > 0 && r.Peek() > tmp) 
                { 
                    s.Push(r.Pop()); 
                }
 
                r.Push(tmp); 

            } 
            
            return r; 
        }

    }
}
