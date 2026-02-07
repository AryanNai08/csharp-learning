
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.DesignPattern
{
    internal class FactoryPattern
    {
        public static void Run()
        {
            IPayment p = PaymentFactory.GetPayment("upi");
            p.Pay();
        }


        interface IPayment
        {
            void Pay();
        }

        class CardPayment : IPayment
        {
            public void Pay() => Console.WriteLine("Card payment");
        }

        class UpiPayment : IPayment
        {
            public void Pay() => Console.WriteLine("UPI payment");
        }

        class PaymentFactory
        {
            public static IPayment GetPayment(string type)
            {
                if (type == "card")
                    return new CardPayment();
                else
                    return new UpiPayment();
            }
        }
    }
}