using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpIntermediate._13_Multithreading_Basics
{
    internal class DownloadSimulation
    {
        static void Download()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Downloading... " + i);
                Thread.Sleep(500);
            }
        }

        public static void Run()
        {
            Thread t = new Thread(Download);
            t.Start();

            Console.WriteLine("User can do other work...");
        }
    }
}
