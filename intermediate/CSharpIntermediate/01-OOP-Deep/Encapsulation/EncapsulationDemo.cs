using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._01_OOP_Deep
{
    internal class EncapsulationDemo
    {
        private int balance = 5000;     //encapsulation no one can access outside the class direclty

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
        }

        public void Withdraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine(amount + " Rupees Withdraw success");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine("Balance: " + balance);
        }


        public static void Run()
        {
            EncapsulationDemo ed = new EncapsulationDemo();
            ed.ShowBalance();
            ed.Deposit(2000);
            ed.Withdraw(3000);
            ed.ShowBalance();
        }
    }
}
