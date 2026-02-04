using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Excersies
{
    internal class SumOfArray
    {
        public static void Run()
        {
            int[] num = new int[5] { 1, 2, 3, 4, 5 };


            int res = Sum(num);
            Console.WriteLine("Sum is:" + res);


        }

        public static int Sum(int[] num)
        {


            if (num.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    sum += num[i];
                }

                return sum;
            }

            return -1;
        }
    }
}
