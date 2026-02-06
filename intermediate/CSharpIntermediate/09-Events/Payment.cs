using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Events
{
    internal class Payment
    {
        static void SendEmail(int amt)
        {
            Console.WriteLine($"Email: Payment of {amt} successful");
        }

        static void UpdateDB(int amt)
        {
            Console.WriteLine($"Database updated for {amt}");
        }

        public static void Run()
        {
            PaymentEvent p = new PaymentEvent();

            p.PaymentSuccess += SendEmail;
            p.PaymentSuccess += UpdateDB;

            p.Pay(5000);
        }
    }
    class PaymentEvent
    {
        public event Action<int> PaymentSuccess;

        public void Pay(int amount)
        {
            Console.WriteLine("Processing payment: " + amount);

            Console.WriteLine("Payment successful!");
            PaymentSuccess?.Invoke(amount);
        }
    }
}

