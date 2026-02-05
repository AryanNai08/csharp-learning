using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05_Collections
{
    internal class Hashtable
    {
        public static void Run()
        {
            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
            hashtable.Add("one", 1);
            hashtable.Add("two", 2);
            hashtable.Add("three", 3);
            foreach (System.Collections.DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
