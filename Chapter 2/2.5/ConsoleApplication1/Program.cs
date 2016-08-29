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
         Given a circular linked list, implement an algorithm which returns node at the beginning of the loop 
         * 
         * DEFINITION 
         * Circular linked list: A (corrupt) linked list in which a node’s next pointer points to an earlier node, 
         * so as to make a loop in the linked list 
         * 
         * EXAMPLE 
         * Input: A -> B -> C -> D -> E -> C [the same C as earlier] 
         * Output: C
        */
        static void Main(string[] args)
        {
            var nodeA = new Node<string>();
            var nodeB = new Node<string>();
            var nodeC = new Node<string>();
            var nodeD = new Node<string>();
            var nodeE = new Node<string>();

            nodeA.Value = "A";
            nodeB.Value = "B";
            nodeC.Value = "C";
            nodeD.Value = "D";
            nodeE.Value = "E";

            var linkedList = new CircularLinkedListResolver<string>();
            linkedList.Add(nodeA);
            linkedList.Add(nodeB);
            linkedList.Add(nodeC);
            linkedList.Add(nodeD);
            linkedList.Add(nodeE);
            linkedList.Add(nodeC);

            Node<string> nodeX = linkedList.FindLoop();
            Console.WriteLine(nodeX.Value);

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }
    }
}

