using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._04_Operators
{
    internal class Operators
    {
        public static void Run()
        {

            int num1 = 10;
            int num2 = 20;

            int sum1 = num1 + num2;
            int sum2 = num2 - num1;
            int sum3 = num1 * num2;
            int sum4 = num2 / num1;
            int sum5 = num2 % num1;

            Console.WriteLine("Numbers are :" + num1 + " and " + num2);

            Console.WriteLine("Addition :" + sum1);
            Console.WriteLine("Subtraction :" + sum2);
            Console.WriteLine("Multiplication :" + sum3);
            Console.WriteLine("Division :" + sum4);
            Console.WriteLine("Modulus :" + sum5);

            string name = "Aryan";
            Console.WriteLine("Name :" + name);
            string greeting = "Hello " + name;

            Console.WriteLine(greeting);
        }
    }
}
