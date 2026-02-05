using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._04_Exception_Handling
{
    internal class ThrowKeyword
    {
        public static void Run()
        {
            try
            {
                int a = 10;
                int b = 0;
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                int c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
            }
        }
    }
}
