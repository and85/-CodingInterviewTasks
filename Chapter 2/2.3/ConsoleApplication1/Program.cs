using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /*
        Implement an algorithm to delete a node in the middle of a single linked list, 
        given only access to that node 
        EXAMPLE 
        Input: the node ‘c’ from the linked list a->b->c->d->e 
        Result: nothing is returned, but the new linked list looks like a->b->d->e
        */
        static void Main(string[] args)
        {
            var myList = new MySinglyLinkedList<string>();
            myList.Add(new MySinglyLinkedListNode<string>() { Value="a"});
            myList.Add(new MySinglyLinkedListNode<string>() { Value = "b" });
            var nodeToRemove = new MySinglyLinkedListNode<string>() { Value = "c" };
            myList.Add(nodeToRemove);
            myList.Add(new MySinglyLinkedListNode<string>() { Value = "d" });
            myList.Add(new MySinglyLinkedListNode<string>() { Value = "e" });

            myList.Remove(nodeToRemove);

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
