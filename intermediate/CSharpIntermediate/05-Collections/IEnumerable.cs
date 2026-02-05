using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05_Collections
{
    internal interface IEnumerable
    {
        public static void Run()
        {
            System.Collections.IEnumerable enumerable = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
        }
    }


    //this program will not execute because of lower version of c#
}
