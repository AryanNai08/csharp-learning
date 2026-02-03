using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._04_Operators
{
    internal class ConditionalOperator
    {
        public static void Run()
        {
            Console.WriteLine("Enter ur age:");

            int age = Convert.ToInt32(Console.ReadLine());

            String eligibility = (age >= 18) ? "You are eligible to vote." : "You are not eligible to vote.";

            Console.WriteLine(eligibility);



        }
    }
}
