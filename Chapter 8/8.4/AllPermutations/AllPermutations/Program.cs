using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string perm in GetPerms("abc"))
            {
                Console.WriteLine(perm);
            }

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        public static List<string> GetPerms(string s)
        {
            var permutations = new List<string>();
            if (s == null)
            {
                return null;
            }
            else if (s.Length == 0)
            {
                permutations.Add("");
                return permutations;
            }
            char first = s[0];
            var remainder = s.Substring(1);
            var words = GetPerms(remainder);
            foreach (string word in words)
            {
                for (int j = 0; j <= word.Length; j++)
                {
                    permutations.Add(InsertCharAt(word, first, j));
                }
            }
            return permutations;
        }

        public static String InsertCharAt(String word, char c, int i)
        {
            string start = word.Substring(0, i);
            var end = word.Substring(i);
            return start + c + end;
        }
    }
}

