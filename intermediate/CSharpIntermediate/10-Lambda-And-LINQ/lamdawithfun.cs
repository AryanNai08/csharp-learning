using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.LamdaExpression
{
    internal class lamdawithfun
    {
        public static void Run()
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(3, 4));
        }
    }
}
