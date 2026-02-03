using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._10_Arrays_And_Collections
{
    internal class Arrays
    {
        public static void Run()
        {
            int[]arr= new int[3];

            //Console.WriteLine("Enter first numbers:");
            //arr[0]= Convert.ToInt32( Console.ReadLine());

            //Console.WriteLine("Enter Second numbers:");
            //arr[1] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter third numbers:");
            //arr[2] = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter {i} numbers:");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
            }
        }
    }
}
