using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics._10_Arrays_And_Collections
{
    internal class Dictionary
    {
        public static void Run()
        {
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                { 1, "Aryan" },
                { 2, "kartik" },
                { 3, "vivek"  }
            };

            names.Add(4,"Ansh");


            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> kvp = names.ElementAt(i);
                Console.WriteLine($"{ kvp.Key}-> { kvp.Value}");
            }

            Console.WriteLine("Using foreach loop");

            foreach (KeyValuePair<int, string> kvp in names)
            {
                Console.WriteLine($"{ kvp.Key}-> { kvp.Value}");
            }
        }
    }
}
