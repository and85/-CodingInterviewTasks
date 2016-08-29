using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class TestHashSet
    {
        public void Test()
        {
            //SimpleUsage();
            //PerformanceInsertTest();
            PerformanceSearchTest();
        }

        private void SimpleUsage()
        {
            HashSet<int> s = new HashSet<int>();
            s.Add(1);
            s.Add(2);
            s.Add(2);
        }

        private static void PerformanceInsertTest()
        {
            HashSet<int> hashSet = new HashSet<int>();

            // how long it will take to insert 1000 elements to the empty collection
            InsertElements(hashSet, 1000);

            // how long it will take to insert 1000000 elements
            InsertElements(hashSet, 10000000);

            // how long it will take to insert 1000 elements to the full collection
            InsertElements(hashSet, 1000);
        }

        private static void PerformanceSearchTest()
        {
            HashSet<int> hashTable = new HashSet<int>();

            // how long it will take to search for an element in the empty collection
            InsertElements(hashTable, 1000);
            SearchElements(hashTable, 1000);


            // how long it will take to insert 1000000 elements
            InsertElements(hashTable, 10000000);

            // how long it will take to search for an element in the full collection
            InsertElements(hashTable, 1000);

            SearchElements(hashTable, 1000);

        }

        private static void InsertElements(HashSet<int> hashSet, int numberOfElements)
        {
            Stopwatch sw = new Stopwatch();

            int value;
            var random = new Random();

            sw.Reset();
            sw.Start();

            for (int i = 0; i < numberOfElements; i++)
            {
                hashSet.Add(i);
            }

            Console.WriteLine("Insering {0} elements: {1}", numberOfElements, sw.Elapsed);
        }

        private static void SearchElements(HashSet<int> hashSet, int numberOfElements)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();

            for (int i = 0; i < numberOfElements; i++)
            {
                hashSet.Contains(i);
            }

            Console.WriteLine("Searching {0}, elements: {1}", numberOfElements, sw.Elapsed);
        }
    }
}
