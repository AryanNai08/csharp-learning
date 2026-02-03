using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._10_Arrays_And_Collections
{
    internal class List
    {
        public static void Run()
        {
            List<int> numbers=new List<int>()
            { 1,2,3,4,5,6,7,8,9};

            numbers.Add(10);

                       
            for(int i=0;i<numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
