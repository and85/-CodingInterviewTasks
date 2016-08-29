using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TestHashtable testHashTable = new TestHashtable();
            testHashTable.Test();
            */

            /*
            TestHashSet testHashSet = new TestHashSet();
            testHashSet.Test();
            */

            /*
            TestDictionary testDictionary = new TestDictionary();
            testDictionary.Test();
            */

            MyHashSet<int> myHashSet = new MyHashSet<int>(10);
            myHashSet.Add(1);
            myHashSet.Add(2);
            myHashSet.Add(55);
            myHashSet.Add(3);
            myHashSet.Add(11);
            myHashSet.Add(11);

            Console.WriteLine(myHashSet.Contains(11));
            Console.WriteLine(myHashSet.Contains(12));
            Console.WriteLine(myHashSet.Contains(2));
            
            myHashSet.Remove(2);
            myHashSet.Remove(2);
            Console.WriteLine(myHashSet.Contains(2));

            foreach(var item in myHashSet)
            {
                Console.WriteLine(item);
            }

            MyHashSet<string> myHashSet2 = new MyHashSet<string>(10);
            myHashSet2.Add("1234");
            myHashSet2.Add("bgd");

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }
    }
}


