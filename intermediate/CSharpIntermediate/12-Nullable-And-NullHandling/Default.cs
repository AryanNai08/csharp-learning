using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._12_Nullable_And_NullHandling
{
    internal class Default
    {
        public static void Run()
        {
            string username = null;

            string display = username ?? "Guest";
            Console.WriteLine(display);
        }
    }
}
