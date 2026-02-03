using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._09_Strings
{
    internal class StringFormatting
    {
        public static void Run()
        {
            string name = "Aryan";
            int age = 21;

            Console.WriteLine($"Name is:{name} \nage is:{age}");

            Console.WriteLine("Name is:{0} \nage is:{1}",name,age);
        }
    }
}
