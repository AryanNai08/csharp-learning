using CSharpAdvance.AsyncAwaitFunctions;
using CSharpAdvance.DepndencyInjection;
using CSharpAdvance.DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AsyncAwait.Run().Wait(); //use wait because there is only single main method in whole project and dont make it async!!
            //CancellationTokenEx.Run().Wait();
            //MultipleAsyncTask.Run().Wait();
            //Taskex.Run().Wait();
            //DI.Run();
            //RepoEx.Run();
                FactoryPattern.Run();
        }
    }
}
