using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.Htttp
{
    internal class Post
    {
       public  static async Task Run()
        {
            HttpClient client = new HttpClient();

            string url = "https://jsonplaceholder.typicode.com/posts";

            var json = "{\"title\":\"test\",\"body\":\"hello\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            Console.WriteLine(response.StatusCode);
        }
    }
}
