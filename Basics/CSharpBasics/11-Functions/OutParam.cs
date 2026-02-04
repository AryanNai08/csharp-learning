using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Functions
{
    internal class OutParam
    {
        public static void Run()
        {
            int n = 0;
            n = num(out n);
            Console.WriteLine(n);

        }

        public static int num(out int num)
        {
            num = 5;
            return num;
        }
    }
}
