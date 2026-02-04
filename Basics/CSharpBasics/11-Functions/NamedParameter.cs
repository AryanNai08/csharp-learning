using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Functions
{
    internal class NamedParameter
    {
        public static void Run()
        {
            String Fullname = "Aryan Nai";
            int age = 22;

            info(name: Fullname, age: age);
        }

        public static void info(String name, int age)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}
