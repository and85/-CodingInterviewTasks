using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CircularLinkedListResolver<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }

        public void Add(Node<T> node)
        {
            if (First == null)
            {
                First = node;
                Last = node;
                
                return;
            }

            Last.Next = node;
            Last = node;
        }

        // Requires an additional storage
        public Node<T> FindLoopWithAdditionalStorage()
        {
            HashSet<Node<T>> uniqueItems = new HashSet<Node<T>>();

            Node<T> curNode = First;
            while (curNode.Next != null)
            {
                if (!uniqueItems.Add(curNode))
                {
                    return curNode;
                }

                curNode = curNode.Next;
            }

            return Last;
        }

        // From the book
        public Node<T> FindLoop()
        {            
            Node<T> head = First;    
            
            Node<T> n1 = head; 
            Node<T> n2 = head; 
   
            // Find meeting point 
            while (n2.Next != null) 
            { 
                n1 = n1.Next; 
                n2 = n2.Next.Next; 
                if (n1 == n2)  
                    break; 
            } 
 
            // Error check - there is no meeting point, and therefore no loop 
            if (n2.Next == null) 
                return null; 
 
            /* Move n1 to Head. Keep n2 at Meeting Point.  Each are k steps 
            /* from the Loop Start. If they move at the same pace, they must 
            * meet at Loop Start. */ 
            n1 = head; 
            while (n1 != n2) 
            { 
                n1 = n1.Next; 
                n2 = n2.Next; 
            } 
            // Now n2 points to the start of the loop. 
            return n2; 
        }
    }
}

