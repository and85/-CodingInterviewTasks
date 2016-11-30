using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    // Write a method to generate the nth Fibonacci number 
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = Fibonacci(n);

            Console.WriteLine(result);
#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        private static int Fibonacci(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 1;

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}
