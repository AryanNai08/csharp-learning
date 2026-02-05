using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._02_Structs_And_Enums
{
    internal class Enumex
    {
        enum OrderStatus
        {
            Pending,
            Packed,
            Shipped,
            Delivered
        }

        public static void Run()
        {
            OrderStatus status = OrderStatus.Packed;
            if (status == OrderStatus.Shipped)
            {
                Console.WriteLine("Order on the way");
            }

            Console.WriteLine("Current status: " + status);
        }
    }
}
