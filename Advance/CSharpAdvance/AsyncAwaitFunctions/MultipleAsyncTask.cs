using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.AsyncAwaitFunctions
{
    internal class MultipleAsyncTask
    {
        public static async Task Run()
        {
            Task t1 = Task1();
            Task t2 = Task2();

            await Task.WhenAll(t1, t2);

            Console.WriteLine("All completed");
        }

        static async Task Task1()
        {
            await Task.Delay(2000);
            Console.WriteLine("Task1 done");
        }

        static async Task Task2()
        {
            await Task.Delay(1000);
            Console.WriteLine("Task2 done");
        }
    }
}
