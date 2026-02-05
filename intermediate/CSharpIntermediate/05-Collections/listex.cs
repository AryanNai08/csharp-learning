using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05_Collections
{
    internal class listex
    {
        public static void Run()
        {
            List<string> users = new List<string>
        {
            "Aryan", "kartik", "vivek"
        };

            foreach (string user in users)
                Console.WriteLine(user);
        }
    }
}
