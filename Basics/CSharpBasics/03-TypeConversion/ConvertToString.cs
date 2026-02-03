using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._02_DataTypes
{
    internal class ConvertToString
    {
        public static void Run()
        {
            string num = "23";
            int age = Convert.ToInt32(num);
            Console.WriteLine("integer value " + age);

            string bignum = "9000000000";
            long bignumber = Convert.ToInt64(bignum);
            Console.WriteLine("long value " + bignumber);

            string neg = "-60";
            double negative = Convert.ToDouble(neg);
            Console.WriteLine("double value " + negative);

            string prec = "4.5";
            float precision = Convert.ToSingle(prec);
            Console.WriteLine("float value " + precision);

            string prc = "14.55";
            decimal price = Convert.ToDecimal(prc);
            Console.WriteLine("decimal value " + price);
        }
    }
}
