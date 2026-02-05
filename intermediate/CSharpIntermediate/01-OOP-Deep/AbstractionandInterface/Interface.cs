using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._01_OOP_Deep.AbstractClassandInterfaces
{
    internal class Interface
    {
        public static void Run()
        {
            IPayment p = new CreditCard();
            p.Pay();

            p = new UPI();
            p.Pay();
        }
    }



    interface IPayment
    {
        void Pay();
    }

    class CreditCard : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paid via credit card");
        }
    }

    class UPI : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paid via UPI");
        }
    }



}