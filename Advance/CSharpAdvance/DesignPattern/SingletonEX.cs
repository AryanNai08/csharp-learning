using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.DesignPattern
{
    internal class SingletonEX
    {
        public static void Run()
        {
            var a = Singleton.GetInstance();
            var b = Singleton.GetInstance();

            a.Show();

            Console.WriteLine(a == b); // true
        }
    }

    class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }

        public void Show()
        {
            Console.WriteLine("Singleton created");
        }
    }
}
