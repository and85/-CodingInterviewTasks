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
        Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column is set to 0 
        */
        static void Main(string[] args)
        {
            const int N = 5;
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = (i + 1) * 10 + j + 1;
            }

            //matrix[2, 3] = 0;
            matrix[0, 1] = 0;

            PrintMatrix(matrix);
            
            ReplaceByZeros(matrix);

            PrintMatrix(matrix);

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        static void ReplaceByZeros(int[,] matrix)
        {
            if (matrix == null) throw new NullReferenceException("Matrix is not defined");

            int n = matrix.GetLength(0);

            List<int> replacedColums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (replacedColums.Contains(j))
                        continue;
                        //matrix[i, j] = 0;

                    if (matrix[i, j] == 0)
                    {
                        
                        for (int k = 0; k < n; k++)
                        {
                            if (k == j)
                                continue;

                            matrix[i, k] = 0;
                            matrix[k, j] = 0;
                        }
                         
                        replacedColums.Add(j);
                        break;
                    }
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

            Console.WriteLine("--------------------------------------");
        }
    }
}
