using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.DepndencyInjection
{
    internal class DI
    {
        public static void Run()
        {
            Engine e = new Engine();
            Car c = new Car(e);

            c.Drive();
        }
    }

    class Engine
    {
        public void Start() => Console.WriteLine("Engine started");
    }

    class Car
    {
        private Engine _engine;

        // dependency injected via constructor
        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void Drive()
        {
            _engine.Start();
        }
    }
}