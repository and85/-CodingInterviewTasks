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
            Console.WriteLine(BitSwapRequired(31, 14));
        }

        public static int BitSwapRequired(int a, int b)
        {
            int count = 0;
            for (int c = a ^ b; c != 0; c = c >> 1)
            {
                count += c & 1;
            }

            return count;
        }
    }
}
