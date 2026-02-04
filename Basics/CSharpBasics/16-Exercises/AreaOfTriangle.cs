using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Excersies
{
    internal class AreaOfTriangle
    {
        public static void Run()
        {
            Console.WriteLine("Enter height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width:");
            int width = Convert.ToInt32(Console.ReadLine());

            int result = calculate(height, width);

            Console.WriteLine("Area of Triangle is:" + result);

        }

        public static int calculate(int height, int width)
        {
            return (width * height) / 2;
        }
    }
}
