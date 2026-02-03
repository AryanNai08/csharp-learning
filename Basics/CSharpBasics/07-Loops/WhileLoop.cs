using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._07_Loops
{
    internal class WhileLoop
    {
        public static void Run()
        {
            Console.WriteLine("Enter number of time u want to print Aryan:");

            int limit = Convert.ToInt32(Console.ReadLine());

            while(limit > 0)
            {
                Console.WriteLine("Aryan");
                limit--;
            }

        }
    }
}
