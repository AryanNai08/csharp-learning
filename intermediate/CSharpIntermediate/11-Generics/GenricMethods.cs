using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    internal class GenricMethods
    {
        static void Print<T>(T data)
        {
            Console.WriteLine(data);
        }

        public static void Run()
        {
            Print(10);
            Print("Hello");
        }
    }
}