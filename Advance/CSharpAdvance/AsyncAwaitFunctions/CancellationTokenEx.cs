using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvance.AsyncAwaitFunctions
{
    internal class CancellationTokenEx
    {
        public static async Task Run()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            var task = LongTask(token);

            cts.CancelAfter(2000); // cancel after 2 sec

            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Task cancelled");
            }
        }

        static async Task LongTask(CancellationToken token)
        {
            for (int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine("Working...");
                await Task.Delay(1000);
            }
        }
    }
}
