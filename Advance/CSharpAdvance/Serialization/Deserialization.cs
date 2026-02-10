using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.Serialization
{
    internal class Deserialization
    {
        static void Main()
        {
            string json = "{\"Id\":1,\"Name\":\"Aryan\"}";

            User u = JsonSerializer.Deserialize<User1>(json);

            Console.WriteLine(u.Name);
        }
    }

    class User1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
