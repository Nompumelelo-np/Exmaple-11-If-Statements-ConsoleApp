using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmaple_11_If_Statements_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //the test can be true/false
         bool isMale = false;
         if (isMale)
            {
                Console.WriteLine("You are Male");
            }
         else {
                Console.WriteLine("You are Female");
            }
         //can also test 2 conditions with and ie && in C#, or is ||
         bool isTall = false;
         if (isTall && isMale)
            {
                Console.WriteLine("You are both male and tall ");
            }
         else if (!isTall && isMale)
            {
                Console.WriteLine("You are not tall, but you are male");
            }
         else
            {
                Console.WriteLine("You are either not tall or not a male");
            }
            Console.Read();
        }
    }
}
