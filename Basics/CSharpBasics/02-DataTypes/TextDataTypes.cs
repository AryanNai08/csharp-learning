using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._02_DataTypes
{
    internal class TextDataTypes
    {
        public static void Run()
        {
            string str = "hello world";
            Console.WriteLine("string value :" + str);

            char c = 'A';
            Console.WriteLine("character value :" + c);

            Console.WriteLine("enter your name :");

            string name = Console.ReadLine();

            Console.WriteLine("name :" + name);
        }
    }
}
