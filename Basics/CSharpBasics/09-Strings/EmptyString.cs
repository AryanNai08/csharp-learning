using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._09_Strings
{
    internal class EmptyString
    {
        public static void Run()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            if(name != string.Empty)
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("string is empty");
            }
        }
    }
}
