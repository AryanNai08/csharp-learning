using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Functions
{
    internal class OptionalParameter
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Second number:");
            //int b = Convert.ToInt32(Console.ReadLine());

            int result = Add(a);
            Console.WriteLine(result);
        }

        public static int Add(int a, int b = 10)
        {
            return a + b;
        }
    }
}
