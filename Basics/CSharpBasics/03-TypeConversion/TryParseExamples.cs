using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._03_TypeConversion
{
    internal class TryParseExamples
    {
        public static void Run() 
        {
            Console.WriteLine("Enter a number:");
            int num= -1;
            bool result= int.TryParse(Console.ReadLine(), out num);

            if(result)
            {
                Console.WriteLine("You entered number: " + num);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }
    }
}
