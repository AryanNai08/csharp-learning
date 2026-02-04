using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Class
{
    internal class Student
    {
        public string name;
        public int age;

        public void setdata(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void displaydata()
        {
            Console.WriteLine($"name is:{name},Age is:{age}");
        }
    }
}
