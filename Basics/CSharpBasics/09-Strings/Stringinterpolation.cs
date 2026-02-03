using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpBasics._09_Strings
{
    internal class Stringinterpolation
    {
        public static void Run()
        {
            string name = "Aryan";
            int age = 30;
            Console.WriteLine($"Name is:{name} \nage is:{age}");
        }
    }
}
