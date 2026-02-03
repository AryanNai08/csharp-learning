using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._16_Exercises
{
    internal class Times_table
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number to display its times table:");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, result);
            }
        }
    }
}
