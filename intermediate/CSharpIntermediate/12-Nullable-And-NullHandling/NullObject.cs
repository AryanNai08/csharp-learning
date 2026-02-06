using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._12_Nullable_And_NullHandling
{
    internal class NullObject
    {
       public static void Run()
        {
            User u = null;

            Console.WriteLine(u?.Name ?? "No user found");
        }
    }
    class User
    {
        public string Name;
    }
}
