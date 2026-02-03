using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._16_Exercises
{
    internal class StringReverse
    {
        public static void Run()
        {
            string name = "Aryan Nai";
            Console.WriteLine("reverse name is:");

            for (int i=name.Length - 1; i >= 0; i--)
            {
                
                Console.Write(name[i]);
            }
            
        }
    }
}
