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
            Console.WriteLine(SwapOddEvenBits(5));
            Console.ReadLine();
        }

        public static int SwapOddEvenBits(int x)
        {
            return (((x & 0xAA) >> 1) | ((x & 0x55) << 1));
        }
    }
}
