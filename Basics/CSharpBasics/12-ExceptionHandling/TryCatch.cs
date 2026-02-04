using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.ExceptionHandling
{
    internal class TryCatch
    {
        public static void Run()
        {
            try
            {
                int res = divide(5, 0);
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                Console.WriteLine("Divide by zero occur");
            }
        }

        public static int divide(int a, int b)
        {
            int res = a / b;
            return res;
        }
    }
}
