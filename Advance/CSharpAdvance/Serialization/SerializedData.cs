using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.Serialization
{
    internal class SerializedData
    {
        public static void Run()
        {
            User u = new User { Id = 1, Name = "Aryan" };

            string json = JsonConvert.SerializeObject(u);


            Console.WriteLine(json);
        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}