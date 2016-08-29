using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class TestHashtable
    {
        public void Test()
        {
            SimpleUsage();
            //PerformanceInsertTest();
            //PerformanceSearchTest();
        }

        private static void SimpleUsage()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "One");
            hashTable.Add(2, "Two");
            hashTable.Add(3, 3);
            //hashTable.Add(3, 4);

            Console.WriteLine(hashTable.ContainsKey(2));
            Console.WriteLine(hashTable[2]);
            Console.WriteLine(hashTable[3]);
        }

        private static void PerformanceInsertTest()
        {
            Hashtable hashTable = new Hashtable();

            // how long it will take to insert 1000 elements to the empty collection
            InsertElements(hashTable, 1000);

            // how long it will take to insert 1000000 elements
            InsertElements(hashTable, 10000000);

            // how long it will take to insert 1000 elements to the full collection
            InsertElements(hashTable, 1000);
        }

        private static void PerformanceSearchTest()
        {
            Hashtable hashTable = new Hashtable();

            // how long it will take to search for an element in the empty collection
            InsertElements(hashTable, 1000);
            SearchKeys(hashTable, 1000);
            SearchElements(hashTable, 1000);
            

            // how long it will take to insert 1000000 elements
            InsertElements(hashTable, 10000000);

            // how long it will take to search for an element in the full collection
            InsertElements(hashTable, 1000);

            SearchKeys(hashTable, 1000);
            SearchElements(hashTable, 1000);
            
        }

        private static void InsertElements(Hashtable hashTable, int numberOfElements)
        {
            Stopwatch sw = new Stopwatch();

            int value;
            var random = new Random();

            sw.Reset();
            sw.Start();

            for (int i = 0; i < numberOfElements; i++)
            {
                value = random.Next();

                hashTable.Add(Guid.NewGuid(), i);
            }

            Console.WriteLine("Insering {0} elements: {1}", numberOfElements, sw.Elapsed);
        }

        private static void SearchKeys(Hashtable hashTable, int numberOfElements)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();

            for (int i = 0; i < numberOfElements; i++)
            {
                hashTable.ContainsKey(Guid.NewGuid());
            }

            Console.WriteLine("Searching {0} keys: {1}", numberOfElements, sw.Elapsed);
        }

        private static void SearchElements(Hashtable hashTable, int numberOfElements)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();

            for (int i = 0; i < numberOfElements; i++)
            {
                hashTable.ContainsValue(i);
            }

            Console.WriteLine("Searching {0}, elements: {1}", numberOfElements, sw.Elapsed);
        }
    }
}
