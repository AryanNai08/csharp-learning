using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._09_Strings
{
    internal class StringEquals
    {
        public static void Run()
        {
            string name = "Aryan";
            string name2 = "Aryan";

            //if (name == name2)
            if(name.Equals(name2))
            {
                Console.WriteLine("same");
            } else{
                Console.WriteLine("Diffrent");
            }
        }
    }
}
