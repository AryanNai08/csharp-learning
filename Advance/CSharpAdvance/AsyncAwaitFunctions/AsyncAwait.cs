using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance
{
    internal class AsyncAwait
    {
        public static async Task Run()
        {
            Console.WriteLine("Start");

            await Download();

            Console.WriteLine("End");
        }

        static async Task Download()
        {
            Console.WriteLine("Downloading...");
            await Task.Delay(3000); // simulate 3 sec work
            Console.WriteLine("Download complete");
        }
    }
}