using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Functions
{
    internal class ReturnTypeFunction
    {
        public static void Run() { }

        public static int ReturnAge()
        {
            return 23;
        }

        public static string ReturnName()
        {
            return "Aryan Nai";
        }
        public static void PrintIntroduction()
        {
            String name = ReturnName();
            int age = ReturnAge();

            Console.WriteLine($"Name is:{name} and age is:{age}");
        }
    }
}

