using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*
     * You have two numbers represented by a linked list, where each node contains a single digit   
     * The digits are stored in reverse order, such that the 1’s digit is at the head of the list   
     * Write a function that adds the two numbers and returns the sum as a linked list 
     * EXAMPLE 
     * Input: (3 -> 1 -> 5), (5 -> 9 -> 2) 
     * Output: 8 -> 0 -> 8
     */
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new DigitsLinkedList();
            list1.Add(3);
            list1.Add(1);
            list1.Add(9);

            var list2 = new DigitsLinkedList();
            list2.Add(5);
            list2.Add(9);
            list2.Add(2);

            DigitsLinkedList list3 = AddListsNotEffective(list1, list2);

#if DEBUG
            Console.WriteLine("END");
            Console.ReadLine();
#endif
        }

        // current implementation doesn't handle cases when lists contain different number of arguments, but it should be easy to fix though
        public static DigitsLinkedList AddListsNotEffective(DigitsLinkedList list1, DigitsLinkedList list2)
        {
            var resultList = new DigitsLinkedList();

            Node curNode1 = list1.Head;
            Node curNode2 = list2.Head;
            int previousDigitsOverflow = 0;
            int digitsSum = 0;
            int maxDigit = 9;

            // iterate through a list till we reach the end.
            while (curNode1.Next != null)
            {
                AddDigits(resultList, curNode1, curNode2, ref previousDigitsOverflow, ref digitsSum, maxDigit);

                curNode1 = curNode1.Next;
                curNode2 = curNode2.Next;
            }
            
            // operate with tails
            AddDigits(resultList, curNode1, curNode2, ref previousDigitsOverflow, ref digitsSum, maxDigit);

            // add one additional node to the end if required
            if (previousDigitsOverflow > 0)
                resultList.Add(previousDigitsOverflow);

            return resultList;
        }

        private static void AddDigits(DigitsLinkedList resultList, Node curNode1, Node curNode2, ref int previousDigitsOverflow, ref int digitsSum, int maxDigit)
        {
            digitsSum = curNode1.Value + curNode2.Value + previousDigitsOverflow;

            if (digitsSum > maxDigit)
            {
                previousDigitsOverflow = 1;
                digitsSum = digitsSum - maxDigit - 1;
            }
            else
            {
                previousDigitsOverflow = 0;
            }

            resultList.Add(digitsSum);
        }
    }
}
