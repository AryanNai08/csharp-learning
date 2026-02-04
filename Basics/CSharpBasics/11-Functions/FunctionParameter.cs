using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Functions
{
    internal class FunctionParameter
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = Add(a, b);
            Console.WriteLine(result);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}