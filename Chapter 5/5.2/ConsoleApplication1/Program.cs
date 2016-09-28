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
            decimal value = (decimal)3.72;
            int[] bits = decimal.GetBits(value);
            string str = string.Join(string.Empty, bits);
            Console.WriteLine(str);

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
