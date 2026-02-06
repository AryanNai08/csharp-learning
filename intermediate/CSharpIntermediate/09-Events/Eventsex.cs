using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Events
{
    internal class Eventsex
    {
        public static void Run()
        {
            Process p = new Process();

            // subscribe event
            p.ProcessCompleted += Message;

            p.StartProcess();
        }

        public static void Message()
        {
            Console.WriteLine("Notification received");
        }


    }


    class Process
    {
        public delegate void Notify();
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process started...");
            Console.WriteLine("Process completed!");

            // raise event
            ProcessCompleted?.Invoke();
        }
    }


    //Subscriber subscribes → Event occurs → Event handler executes
}
