
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Structure
{
    internal class Struct
    {
        struct Person
        {
            public String name;
            public int age;
        }
        public static void Run()
        {
            Person person;
            Console.WriteLine("Enter ur name:");
            person.name = Console.ReadLine(); ;

            Console.WriteLine("Enter ur age:");
            person.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name is:{person.name}-age is:{person.age}");
        }


    }
}