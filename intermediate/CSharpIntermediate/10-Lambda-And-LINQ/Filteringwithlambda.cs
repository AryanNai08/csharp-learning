using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.LamdaExpression
{
    internal class Filteringwithlambda
    {
        public static void Run()
        {
            List<int> nums = new List<int> { 10, 25, 30, 45 };

            var result = nums.Where(x => x > 20);

            foreach (var n in result)
                Console.WriteLine(n);
        }
    }
}

