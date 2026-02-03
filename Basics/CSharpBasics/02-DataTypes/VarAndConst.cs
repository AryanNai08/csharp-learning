using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._02_DataTypes
{
    internal class VarAndConst
    {
        public static void Run()
        {
            var age = 23;
            Console.WriteLine("integer value " + age);

            var bignumber = 9000000000l;
            Console.WriteLine("long value " + bignumber);

            var negative = -60d;
            Console.WriteLine("double value " + negative);

            var precision = 4.5f;
            Console.WriteLine("float value " + precision);

            var price = 14.55M;
            Console.WriteLine("decimal value " + price);

            var name = "Aryan Nai";
            Console.WriteLine("string value :" + name);


            const double pi = 3.14;
            Console.WriteLine("Value of pi :" + pi);
        }
    }
}
