using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Genric
{
    internal class Repository
    {
        public static void Run()
        {
            Repository<string> repo = new Repository<string>();
            repo.Add("User1");
            repo.Add("User2");

            repo.Show();
        }


    }

    class Repository<T>
    {
        List<T> data = new List<T>();

        public void Add(T item)
        {
            data.Add(item);
        }

        public void Show()
        {
            foreach (var i in data)
                Console.WriteLine(i);
        }
    }
}
