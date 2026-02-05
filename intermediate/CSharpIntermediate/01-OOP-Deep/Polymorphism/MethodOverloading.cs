using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._01_OOP_Deep.Polymorphism
{
    internal class MethodOverloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void Run()
        {
            MethodOverloading md = new MethodOverloading();

            Console.WriteLine("two parameter -" + md.Add(5, 5));
            Console.WriteLine("three parameter -" + md.Add(5, 5, 5));

        }
    }
}