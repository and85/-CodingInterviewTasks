using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class MyHashSet<T> : ICollection<T>
    {
        // we could use LinkedList to avoid memory defragmentation in a case of an array that stores all data in a single block. 
        // If an array becomes to big (exceeds 85000 bytes), it will be allocated on the Large Object Heap, that can lead to memory fragmentation
        // but in a case of LinkedList, search will take O(n) time (we don't have indexes) - we are trying to achieve O(1) 
        private List<T>[] _buckets { get; set; }
        
        private int _size;
        
        public MyHashSet(int size)
        {
            _size = size;
            _buckets = new List<T>[size];

            for (int i=0; i<size; i++)
            {
                _buckets[i] = new List<T>();
            }
        }

        public void Add(T item)
        {
            int index = GetBucketIndex(item);

            if (!_buckets[index].Contains(item))
            {
                _buckets[index].Add(item);
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            int index = GetBucketIndex(item);
            return _buckets[index].Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            int index = GetBucketIndex(item);
            int count = _buckets[index].RemoveAll(x => x.Equals(item));

            return (count > 0);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                foreach (var item in _buckets[i])
                {
                    yield return item;
                }
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private int GetBucketIndex(T element)
        {
            /*
            https://en.wikipedia.org/wiki/Hash_function
            https://en.wikipedia.org/wiki/Chi-squared_test
            https://en.wikipedia.org/wiki/Rabin–Karp_algorithm
            https://en.wikipedia.org/wiki/Cyclic_redundancy_check
            https://en.wikipedia.org/wiki/MurmurHash
            */
            
            // the simpliest possible function :)
            int index = Math.Abs(element.GetHashCode() % _size);
            return index;
        }
    }
}
