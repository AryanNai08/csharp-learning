using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._02_Structs_And_Enums
{


    internal class Struct
    {
        struct Point
        {
            public int x;
            public int y;

            public void Show()
            {
                Console.WriteLine($"X: {x}, Y: {y}");
            }
        }

        public static void Run() 
        {
            Point p;
            p.x = 10;
            p.y = 20;

            p.Show();
        }
    }
}
