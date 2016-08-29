using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    /*
    Implement an algorithm to find the nth to last element of a singly linked list
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

            Console.WriteLine(myList.NthToLast(6).Value);
            

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }
    }
}



