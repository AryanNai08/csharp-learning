using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._01_OOP_Deep
{
    internal class InheritanceDemo   //parent class
    {
        public string name;
        public int salary;

        public void Show()
        {
            Console.WriteLine(name + " " + salary);
        }

        public static void Run()
        {
            Manager m = new Manager();
            m.name = "Aryan Nai";
            m.salary = 40000;
            m.bonus = 10000;

            m.Show();
            m.ShowTotal();
        }
    }

    class Manager : InheritanceDemo   //child class inherit parent
    {
        public int bonus;

        public void ShowTotal()
        {
            Console.WriteLine("Total: " + (salary + bonus));
        }
    }

}
