using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._03_Properties_And_Indexers
{
    internal class Initex
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        //public string Name { get; init; }
        //public int Salary { get; init; }
    }


    // the execution of this program depend on version 9.0 or above of C#

    class Program
    {
       public static void Run()
        {
            var e = new Initex
            {
                Name = "Aryan Nai",  //allow data assign at object creation only!!!!
                Salary = 50000
            };

            Console.WriteLine($"{e.Name} - {e.Salary}");
        }
    }
}
