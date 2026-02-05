using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._01_OOP_Deep.AbstractClassandInterfaces
{
    internal class AbstractClass
    {
        public static void Run()
        {
            Vehicle v = new Car();
            v.Start();
            v.Stop();

        }
    }


    abstract class Vehicle
    {
        public abstract void Start();

        public void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car started");
        }
    }



}