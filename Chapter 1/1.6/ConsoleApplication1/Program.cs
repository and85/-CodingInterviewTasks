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
        Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate 
        the image by 90 degrees  Can you do this in place?
        */
        static void Main(string[] args)
        {
            const int N = 5;
            int[,] matrix = new int[N,N];
            for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = (i + 1) * 10 + j + 1;
            }

            PrintMatrix(matrix);

            Console.WriteLine("-----------------------------------");

            //RotateNotEffective(N, matrix);
            RotateOptimised(N, matrix);

            PrintMatrix(matrix);
#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        private static void RotateNotEffective(int n, int[,] matrix)
        {
            int temp;
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                {
                    if (i != j)
                    {
                        temp = matrix[i, j];
                        matrix[i, j] = matrix[j, i];
                        matrix[j, i] = temp;
                    }
                }
        }

        // solution from the book, actually it does a bit different thing than a matrix transpose
        public static void RotateOptimised(int n, int[,] matrix)
        {
            for (int layer = 0; layer < n / 2; ++layer)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; ++i)
                {
                    int offset = i - first;
                    int top = matrix[first, i]; // save top     
                    // left -> top 9    
                    matrix[first, i] = matrix[last - offset, first];
                    // bottom -> left 
                    matrix[last - offset, first] = matrix[last, last - offset];
                    // right -> bottom 
                    matrix[last, last - offset] = matrix[i, last];
                    // top -> right 
                    matrix[i, last] = top;
                    // right <- saved top 
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write("     ");
                }
                Console.WriteLine();
            }
        }
    }
}
