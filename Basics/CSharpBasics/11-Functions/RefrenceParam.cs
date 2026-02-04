using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Functions
{
    internal class RefrenceParam
    {
        public static void Run()
        {
            int n = 0;
            num(ref n);
            Console.WriteLine(n);

        }

        public static int num(ref int num)
        {
            num = 5;
            return num;
        }
    }
}