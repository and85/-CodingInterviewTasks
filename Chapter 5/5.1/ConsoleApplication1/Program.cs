using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //You are given two 32-bit numbers, N and M, and two bit positions, i and j 
        //Write a method to set all bits between i and j in N equal to M
        //(e g, M becomes a substring of N located at i and starting at j)   
        //EXAMPLE: Input: N = 10000000000, M = 10101, i = 2, j = 6 Output: N = 10001010100
        static void Main(string[] args)
        {
            //set bit
            //int bitIndex = 2;
            //int mask = 1 << bitIndex;
            //N |= mask;

            // get bit
            //int bitIndex = 2;
            //int mask = 1 << bitIndex;
            //int masked_n = M & mask;
            //int thebit = masked_n >> bitIndex;

            //int N = MySolution();
            int N = Convert.ToInt32("10000000000", 2);
            int M = Convert.ToInt32("10101", 2);

            int i = 2;
            int j = 6;

            //N = MySolution(N, M);
            N = updateBits(N, M, i, j);

            //updateBits

            Console.WriteLine(N);
            Console.WriteLine("END");
            Console.ReadKey();
        }

        private static int MySolution(int N, int M, int i, int j)
        {
            
            
            int mIndex = 0;

            for (int bitIndex = i; bitIndex <= j; bitIndex++)
            {
                int mask = 1 << mIndex;
                int masked_n = M & mask;
                int thebit = masked_n >> mIndex;

                mask = thebit << bitIndex;
                N |= mask;

                mIndex++;
            }

            return N;
        }

        public static int updateBits(int n, int m, int i, int j)
        {
            int max = ~0; /* All 1’s */

            // 1’s through position j, then 0’s 
            int left = max - ((1 << j) - 1);

            // 1’s after position i 
            int right = ((1 << i) - 1);

            // 1’s, with 0s between i and j 
            int mask = left | right;

            // Clear i through j, then put m in there 
            return (n & mask) | (m << i);
        }
    }
}
