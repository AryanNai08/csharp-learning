using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._06_ControlStatements
{
    internal class IfElse
    {
        public static void Run()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are an adult.");
            }else if (age < 18  && age>12)
            {
                 Console.WriteLine("You are teenager.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }
        }
    }
}
