using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._09_Strings
{
    internal class VerbatimStrings
    {
        public static void Run()
        {
            // \t \n \\ \"

            string path = "D:\\DSA\\DSA Prog.zip\\DSA Prog\\ArrayProgs"+"\nnew line";

            Console.WriteLine(path);

            string path2a = @"D:\DSA\DSA Prog.zip\DSA Prog\ArrayProgs";
            Console.WriteLine(path2a);
            string name = "'Aryan with single quote'";
            Console.WriteLine(name);

            string name2="\"Aryan with double quote\"";
            Console.WriteLine(name2);
        }
    }
}
