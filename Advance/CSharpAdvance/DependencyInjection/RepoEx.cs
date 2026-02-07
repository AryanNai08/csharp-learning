using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.DepndencyInjection
{
    internal class RepoEx
    {
        public static void Run()
        {
            var repo = new UserRepository();
            var service = new UserService(repo);

            service.Show();
        }
    }

    class UserRepository
    {
        public void GetUsers()
        {
            Console.WriteLine("Fetching users");
        }
    }

    class UserService
    {
        private UserRepository repo;

        public UserService(UserRepository r)
        {
            repo = r;
        }

        public void Show()
        {
            repo.GetUsers();
        }
    }
}
