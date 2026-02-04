using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Functions
{
    internal class VoidFunctions
    {
        //public static void Run() 
        //{
        //    CreateAndPrintArray();
        //}

        public static void CreateAndPrintArray()
        {
            int[] numbers = new int[5]
            {
                1,2,3,4,5
            };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}