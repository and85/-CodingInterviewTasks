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
        Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer  
         * NOTE: One or two additional variables are fine   
         * An extra copy of the array is not FOLLOW UP Write the test cases for this method 
        */
        static void Main(string[] args)
        {
            string input = "abbccd";

            var remover = new Remover();
            input = remover.Remove(input);

            Console.WriteLine(input);
        }
    }
}
