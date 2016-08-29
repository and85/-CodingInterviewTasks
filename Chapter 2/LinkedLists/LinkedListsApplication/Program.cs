using System;
using System.Text;
using System.Collections.Generic;
using LinkedListsApplication;

public class Program
{
    public static void Main()
    {
        var myList = new MySinglyLinkedList<string>();
        myList.Add("1");
        myList.Add("2");
        myList.Add("3");
        myList.Add("4");
        myList.Add("5");
        myList.Add("6");
        myList.Add("6");

        myList.Remove("3");
        myList.Remove("6");

        foreach (string item in myList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(myList.Contains("3"));
        Console.WriteLine(myList.Contains("8"));

#if DEBUG
        Console.WriteLine("END");
        Console.ReadLine();
#endif
    }
}