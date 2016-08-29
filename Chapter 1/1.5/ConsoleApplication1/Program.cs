using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Write a method to replace all spaces in a string with ‘%20’ 
        static void Main(string[] args)
        {
            string str = Replace(" abc def gh ");
            Console.WriteLine(str);

            string str2 = ReplaceOptimized(" abc def gh ");
            Console.WriteLine(str2);

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        public static string Replace(string input)
        {
            char[] token = "%20".ToCharArray();
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    Array.Resize(ref chars, chars.Length + token.Length-1);
                    Array.Copy(chars, i+1, chars, i+token.Length, chars.Length-i-token.Length);
                    Array.Copy(token, 0, chars, i, token.Length);
                }
            }

            return string.Join(string.Empty, chars);
        }

        public static string ReplaceOptimized(string input) 
        {
            char[] chars = input.ToCharArray();
            int length = input.Length;

            int spaceCount = 0, newLength, i = 0; 
            for (i = 0; i < length; i++) 
            {    
                if (chars[i] == ' ') 
                    spaceCount++; 
            } 

            newLength = length + spaceCount * 2; 
            Array.Resize(ref chars, newLength);

            for (i = length - 1; i >= 0; i--) 
            { 
                if (chars[i] == ' ') 
                { 
                    chars[newLength - 1] = '0'; 
                    chars[newLength - 2] = '2'; 
                    chars[newLength - 3] = '%'; 
                    newLength = newLength - 3; 
                } 
                else 
                {   
                    chars[newLength - 1] = chars[i]; 
                    newLength = newLength - 1; 
                }  
            }

            return string.Join(string.Empty, chars);
        }
    }
}
