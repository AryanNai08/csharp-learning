using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.AsyncAwaitFunctions
{
    internal class Taskex
    {
        public static async Task Run()
        {
            int result = await GetNumber();
            Console.WriteLine(result);
        }

        static async Task<int> GetNumber()
        {
            await Task.Delay(2000);
            return 100;
        }
    }
}