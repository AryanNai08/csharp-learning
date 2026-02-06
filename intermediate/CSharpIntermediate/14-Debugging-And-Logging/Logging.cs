using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._14_Debugging_And_Logging
{
    internal class Logging
    {
        public static void Run()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                // Log the exception to a file or logging system
                Console.WriteLine("Error logged");
            }
        }
    }
}
