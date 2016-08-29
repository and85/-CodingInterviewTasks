using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class TestDictionary
    {
        public void Test()
        {
            //SimpleUsage();
            //PerformanceInsertTest();
            PerformanceSearchTest();
        }

        private void SimpleUsage()
        {
            Dictionary<int, int> genericDictionary = new Dictionary<int, int>();
        }

        private static void PerformanceInsertTest()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            // how long it will take to insert 1000 elements to the empty collection
            InsertElements(dictionary, 0, 1000);

            // how long it will take to insert 1000000 elements
            InsertElements(dictionary, 10001, 10000000);

            // how long it will take to insert 1000 elements to the full collection
            InsertElements(dictionary, 10000001, 1000);
        }

        private static void PerformanceSearchTest()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            // how long it will take to search for an element in the empty collection
            InsertElements(dictionary, 0, 1000);
            SearchKeys(dictionary, 1000);

            // how long it will take to insert 1000000 elements
            InsertElements(dictionary, 10001, 10000000);

            // how long it will take to search for an element in the full collection
            InsertElements(dictionary, 100000001, 1000);

            SearchKeys(dictionary, 1000);
        }

        private static void InsertElements(Dictionary<int, int> dictionary, int firstElement, int numberOfElements)
        {
            Stopwatch sw = new Stopwatch();

            int value;
            var random = new Random();

            sw.Reset();
            sw.Start();

            for (int i = firstElement; i < firstElement + numberOfElements; i++)
            {
                value = random.Next();

                dictionary.Add(i, i);
            }

            Console.WriteLine("Insering {0} elements: {1}", numberOfElements, sw.Elapsed);
        }

        private static void SearchKeys(Dictionary<int, int> dictionary, int numberOfElements)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();

            for (int i = 0; i < numberOfElements; i++)
            {
                dictionary.ContainsKey(i);
            }

            Console.WriteLine("Searching {0} keys: {1}", numberOfElements, sw.Elapsed);
        }
    }
}
