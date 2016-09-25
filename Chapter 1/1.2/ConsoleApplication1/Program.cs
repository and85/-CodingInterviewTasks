using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // Write code to reverse a C-Style String  (C-String means that “abcd” is represented as five characters, 
        // including the null character 
        static void Main(string[] args)
        {
            // Since it's not that easy to create C-Sctring in C#, I'll use just an ordinary string, I believe the algorithm should be the same 
            string input = "abcde";
            
            char c = input[0];

            unsafe
            {
                char* px1 = &c;
                UnsafeReverseChar(px1);
            }
#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif

        }

        /// <summary>
        /// Time complexity O(n/2), memory usage O(n)
        /// </summary>
        private static string ReverseString(string input)
        {
            int n = input.Length;
            char[] chars = input.ToCharArray();

            for (int i=0; i < n/2; i++)
            {
                chars[i] = input[n-i-1];
                chars[n-i-1] = input[i];
            }

            return chars.ToString();
        }

        ???
        /*
        private unsafe static void UnsafeReverseChar(char* str)
        {
            char* end = str;
            char tmp;
            if ((str != null) && (str[0] == '\0'))
            {
                while ((end != null) && (end[0] == '\0'))
                {
                    ++end;
                } --end;
                while (str < end)
                {
                    tmp = *str;
                    *str++ = *end; *end-- = tmp;
                }
            } 
        }
        */
    }
}
