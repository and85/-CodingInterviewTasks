using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // Write a method to decide if two strings are anagrams or not 
        /*
         An anagram of a string is another string that contains same characters, 
         * only the order of characters can be different. For example, “abcd” and “dabc” are anagram of each other.
        */
        static void Main(string[] args)
        {
            Console.WriteLine(AreAnagrams("abcd", "dabc"));
            Console.WriteLine(AreAnagrams("ebed", "dabc"));


#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        // O(n) complexity
        public static bool AreAnagrams(string input1, string input2)
        {
            if (input1.Length != input2.Length)
                return false;

            int[] entries1 = GetEntries(input1);
            int[] entries2 = GetEntries(input2);


            // in fact after we caclulated entries1 we could return false once a number of some characters in entries2 exceeds 
            // what we have in entries1, but anyway it would be the same O(n)
            for (int i = 0; i < entries1.Length; i++)
            {
                if (entries1[i] != entries2[i])
                    return false;
            }

            return true;
        }

        private static int[] GetEntries(string input)
        {
            char[] chars = input.ToCharArray();

            int firstASCISymbol = 97;
            int numberOfLetters = 26;

            int[] entries = new int[numberOfLetters];

            for (int i = 0; i < chars.Length; i++)
            {
                int index = chars[i] - firstASCISymbol;
                entries[index]++;
            }

            return entries;
        }
    }
}
