using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._16_Exercises
{
    internal class Arrayofmultiples
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number for table genration:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of array:");
            int size= Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = num * (i + 1);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
