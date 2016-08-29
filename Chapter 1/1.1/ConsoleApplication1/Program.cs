using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters  What if you can not use additional data structures
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "abcdefgaz";
            UniqueCharactersHashSet(testString);
            UniqueCharactersWithoutDataStructures(testString);
            UniqueCharactersBitArray(testString);
            UniqueCharactersBitVector(testString);
#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        // O(n) complexity using HashSet
        private static bool UniqueCharactersHashSet(string input)
        {
            HashSet<string> uniqueCharacters = new HashSet<string>(); 
            // O(n) complexity because of this loop
            foreach (var character in input)
            {
                // O(1) complexity for Contains and Insert operations
                if (!uniqueCharacters.Contains(character.ToString()))
                {
                    uniqueCharacters.Add(character.ToString());
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        // O(n) complexity
        private static bool UniqueCharactersWithoutDataStructures(string input)
        {
            bool[] char_set = new bool[256]; 
            for (int i = 0; i < input.Length; i++) 
            {
                int val = input[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true; 
            }   
            
            return true;
        }

        private static bool UniqueCharactersBitArray(string input)
        {
            // read about BitVector and BitArray in C#
            BitArray char_set = new BitArray(256, false);
            for (int i = 0; i < input.Length; i++)
            {
                int val = input[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }

            return true;
        }

        private static bool UniqueCharactersBitVector(string input)
        {
            return false;
        }
    }
}
