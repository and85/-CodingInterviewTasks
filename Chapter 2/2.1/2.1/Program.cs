using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    /*
    Write code to remove duplicates from an unsorted linked list 
    FOLLOW UP 
    How would you solve this problem if a temporary buffer is not allowed? 
    */
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MySinglyLinkedList<string>();
            myList.Add("6");
            myList.Add("1");
            myList.Add("2");
            myList.Add("3");
            myList.Add("3");
            myList.Add("6");
            myList.Add("2");
            myList.Add("6");

            //myList.RemoveDuplicatesWithTempBuffer();
            myList.RemoveDuplicatesWithoutTempBuffer();

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }
    }
}



