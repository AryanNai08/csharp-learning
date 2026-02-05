using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05_Collections
{
    internal class Stack
    {
        public static void Run()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            while (numbers.Count > 0)
            {
                int number = numbers.Pop();
                Console.WriteLine(number);
            }
        }
    }
}
