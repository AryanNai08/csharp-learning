using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._02_DataTypes
{
    internal class NumericDataTypes
    {
        public static void Run()
        {
            int age = 23;
            Console.WriteLine("integer value " + age);

            long bignumber = 9000000000l;
            Console.WriteLine("long value " + bignumber);

            double negative = -60d;
            Console.WriteLine("double value " + negative);

            float precision = 4.5f;
            Console.WriteLine("float value " + precision);

            decimal price = 14.55M;
            Console.WriteLine("decimal value " + price);

        }
    }
}
