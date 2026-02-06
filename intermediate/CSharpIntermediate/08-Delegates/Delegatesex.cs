using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Delegates
{
    internal class Delegatesex
    {
        delegate void SumDelegate(int a, int b);

        public static void Run()
        {
            SumDelegate s = Add;
            s(10, 20);
        }

        static void Add(int x, int y)
        {
            Console.WriteLine("Sum: " + (x + y));
        }
    }
}