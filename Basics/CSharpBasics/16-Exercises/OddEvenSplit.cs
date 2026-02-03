using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._16_Exercises
{
    internal class OddEvenSplit
    {
        public static void Run()
        {
            int[] arr = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            int[] Evenarr = new int[5];
            int[] Oddarr = new int[5];
            int evenIndex = 0;
            int oddIndex = 0;





            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Evenarr[evenIndex] = arr[i];
                    evenIndex++;
                }
                else
                {
                    Oddarr[oddIndex] = arr[i];
                    oddIndex++;
                }
            }

            Console.WriteLine("Even array");

            for (int i = 0; i < Evenarr.Length; i++)
            {
                Console.Write($"{Evenarr[i]}"+" ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Odd array");

            for (int i = 0; i < Oddarr.Length; i++)
            {
                Console.Write($"{Oddarr[i]}"+" ");
            }
        }
    }
}
