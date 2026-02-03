using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._16_Exercises
{
    internal class PasswordChecker
    {
        public static void Run()
        {
            
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            Console.WriteLine("Rewrite the password");
            string rewritePassword = Console.ReadLine();

            if (password.Equals(string.Empty) || rewritePassword.Equals(string.Empty))
            {
                Console.WriteLine("Password cannot be empty");
            }
            else

            {
                if (!password.Equals(rewritePassword))
                {
                    Console.WriteLine("Passwords do not match");
                }
                else
                {
                    Console.WriteLine("Password match");
                }
            } 

        }
    }
}
