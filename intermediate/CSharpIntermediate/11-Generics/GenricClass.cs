using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Genric
{
    internal class GenricClass
    {
        public static void Run()
        {
            Box<int> b1 = new Box<int>();
            b1.Set(10);
            Console.WriteLine(b1.Get());

            Box<string> b2 = new Box<string>();
            b2.Set("Hello");
            Console.WriteLine(b2.Get());
        }

        class Box<T>
        {
            public T Value;

            public void Set(T val)
            {
                Value = val;
            }

            public T Get()
            {
                return Value;
            }
        }
    }
}
