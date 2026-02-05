using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05_Collections
{
    internal class Dictionary
    {
        public static void Run()
        {
            Dictionary<int, string> users = new Dictionary<int, string>
        {
            {1,"Aryan"},
            {2,"kartik"}
        };

            Console.WriteLine(users[1]);
        }
    }
}
