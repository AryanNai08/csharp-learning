using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._12_Nullable_And_NullHandling
{
    internal class NullableSystem
    {
        public static void Run()
        {
            int? age = null;

            if (age.HasValue)
                Console.WriteLine(age.Value);
            else
                Console.WriteLine("Age not entered");
        }
    }
}
