using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpIntermediate._01_OOP_Deep
{
    internal class InheritanceBaseKeyword
    {
        public string name;

        // Parent constructor
        public InheritanceBaseKeyword(string name)
        {
            this.name = name;
            Console.WriteLine("Parent constructor called");
        }

        public void Show()
        {
            Console.WriteLine($"Parent method called Name: {name}");
        }


        public static void Run()
        {
            Student s = new Student("Aryan", 95);
            s.Show();
        }
    }

    class Student : InheritanceBaseKeyword
    {
        public int marks;

        // Child constructor calling parent constructor using base
        public Student(string name, int marks) : base(name)   //callimg parent consturcter-same as super keyword in java
        {
            this.marks = marks;
            Console.WriteLine("Student constructor called");
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine($"chid method called: Name: {name}, Marks: {marks}");
        }
    }
}