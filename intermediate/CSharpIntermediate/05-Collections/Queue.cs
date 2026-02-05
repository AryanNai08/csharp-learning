using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05_Collections
{
    internal class Queue
    {
        public static void Run()
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            while (numbers.Count > 0)
            {
                int number = numbers.Dequeue();
                Console.WriteLine(number);
            }
        }
    }
}
