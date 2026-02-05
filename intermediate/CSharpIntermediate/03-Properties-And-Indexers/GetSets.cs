using CSharpIntermediate._01_OOP_Deep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._03_Properties_And_Indexers
{
    internal class GetSets
    {
        private int marks;

        public int Marks
        {
            get { return marks; }
            set
            {
                if (value >= 0 && value <= 100)
                    marks = value;
                else
                    Console.WriteLine("Invalid marks");
            }
        }

       public  static void Run()
        {
            GetSets s = new GetSets();
            s.Marks = 85;
            Console.WriteLine(s.Marks);
        }
    }
}
