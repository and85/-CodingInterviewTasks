using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function to swap a number in place without temporary variables  
            int a = -11;
            int b = -245;
            
            /*
            a = a + b;
            b = a - b;
            a = a - b;
            */
            
            // a = (a+b) - (b=a) - is not guaranteed?

            /*
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            */

            /*
            a ^= b;
            b ^= a;
            a ^= b;
            */

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
