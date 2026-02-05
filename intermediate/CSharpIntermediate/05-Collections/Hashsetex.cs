using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05_Collections
{
    internal class Hashsetex
    {
        public static void Run()
        {
            HashSet<string> emails = new HashSet<string>
        {
            "a@gmail.com",
            "b@gmail.com",
            "a@gmail.com"
        };

            foreach (var e in emails)
                Console.WriteLine(e);
        }
    }
    }

