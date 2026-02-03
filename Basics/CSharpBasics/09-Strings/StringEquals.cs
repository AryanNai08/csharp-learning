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

            //if (name == name2)    //check for value and memory location
                if (name.Equals(name2))  //check for values only
            {
                Console.WriteLine("same");
            } else{
                Console.WriteLine("Diffrent");
            }
        }
    }
}
