using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._16_Exercises
{
    internal class OddEvenChecker
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number to check even or odd:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("num is even");
            }
            else
            {
                Console.WriteLine("num is odd");
            }
        }
    }
}
