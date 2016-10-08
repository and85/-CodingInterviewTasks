using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Given a(decimal - e.g. 3.72) number that is passed in as a string, print the binary representation   
        //If the number can not be represented accurately in binary, print “ERROR”
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse("5");

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
