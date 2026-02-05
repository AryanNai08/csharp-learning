using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._04_Exception_Handling
{
    internal class CustomException : Exception
    {
        public CustomException(string msg) : base(msg) { }
    }

    class Bank
    {
       public static void Run()
        {
            int balance = 5000;

            try
            {
                Console.WriteLine("Enter withdraw amount:");
                int amt = Convert.ToInt32(Console.ReadLine());

                if (amt > balance)
                    throw new CustomException("Balance too low");

                balance -= amt;
                Console.WriteLine("Withdraw success");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction completed");
            }
        }
    }
}
