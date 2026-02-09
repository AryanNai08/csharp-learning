using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.Htttp
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;


    internal class GetReq
    {
        public static async Task Run()
        {
             HttpClient client = new HttpClient();

            string url = "https://jsonplaceholder.typicode.com/posts/1";

            string response = await client.GetStringAsync(url);

            Console.WriteLine(response);
        }

    }
}
