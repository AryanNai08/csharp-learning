using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._01_OOP_Deep.Polymorphism
{
    internal class MethodOverriding
    {
        public virtual void Sound()                 //Virtual keyword-Allows method to be overridden.
        {
            Console.WriteLine("Animal makes sound");
        }

        public virtual void PSound()                 //Virtual keyword-Allows method to be overridden.
        {
            Console.WriteLine("Animal makes sound");
        }

        public static void Run()
        {
            MethodOverriding md = new Dog();
            md.Sound();
            md.PSound();
        }
    }

    class Dog : MethodOverriding
    {
        public override void Sound()        //overide keyword-Used in child class.
        {
            Console.WriteLine("Dog barks");
        }
    }
}
