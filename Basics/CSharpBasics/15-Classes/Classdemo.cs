using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics.Class
{
    internal class Classdemo
    {
        public static void Run()
        {
            Student student = new Student();
            student.setdata("AryanNai", 22);
            student.displaydata();
        }

        public static void classfunction()
        {
            Student student = new Student();
            student.setdata("AryanNai", 22);
            displaydatainclassdemo(student);
        }

        public static void displaydatainclassdemo(Student student)
        {
            Console.WriteLine(student.name + "," + student.age);
        }


    }
}