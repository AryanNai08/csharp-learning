using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05_Collections
{
    internal class Arraylist
    {
        public static void Run()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
