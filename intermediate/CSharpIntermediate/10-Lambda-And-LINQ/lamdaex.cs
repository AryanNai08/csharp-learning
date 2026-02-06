using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    delegate int Square(int x);
    internal class lamdaex
    {
        public static void Run()
        {
            Square s = x => x * x;
            Console.WriteLine(s(5));
        }
    }
}