using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Remover
    {
        /* MyImplementation */
        public string Remove(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                return input;
            }

            char[] chars = input.ToCharArray();

            int counter = 0;

            for (int i = 0; i < chars.Length - counter - 1; i++)
            for (int j = i + 1; j < chars.Length; j++)
            {
                if (chars[j] == chars[i])
                {
                    // duplicate
                    for (int k = j; k < chars.Length - 1; k++)
                    {
                        chars[k] = chars[k+1];
                    }
                    counter++;
                }
            }

            Array.Resize<char>(ref chars, chars.Length - counter);
            
            return new string(chars);
        }
        

        /* implementation from a book, contains a bug, i.e abbccd doesn't work properly, maybe would work in C++? 
        public string Remove(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                return input;
            }

            char[] chars = input.ToCharArray();
            int len = chars.Length;

            int tail = 1;
            for (int i = 1; i < len; ++i)
            {
                int j; for (j = 0; j < tail; ++j) 
                {
                    if (chars[i] == chars[j]) 
                        break; 
                } 
                
                if (j == tail) 
                {
                    chars[tail] = chars[i]; 
                    ++tail; 
                }
            }
            chars[tail] = '\0';

            return new string(chars);
        }
        */
        /* implementation from a book, contains a bug, i.e abbccd doesn't work properly, maybe would work in C++? 
        public string Remove(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                return input;
            }

            char[] chars = input.ToCharArray();
            int len = chars.Length;

            bool[] hit = new bool[256]; 
            for (int i = 0; i < 256; ++i) { hit[i] = false; }

            hit[chars[0]] = true; 
            int tail = 1;

            for (int i = 1; i < len; ++i)
            {
                if (!hit[chars[i]]) 
                { 
                    chars[tail] = chars[i]; 
                    ++tail; 
                    hit[chars[i]] = true; 
                } 
            }

            chars[tail] = '\0'; 

            return new string(chars);
        }
        */
    }
}
