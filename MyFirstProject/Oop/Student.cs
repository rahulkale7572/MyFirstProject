using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oop
{
    class Student
    {
        public int id;
        public string name;
        public int h;
        public int e;
        public int s;
        public int total;
        public double per;

        static void Main(string[] args)
        {
            Student student = new Student();
            student.id = 225;
            student.name = "Rahul";
            student.h = 75;
            student.e = 80;
            student.s = 85;
            student.total = 75 + 80 + 85;
            student.per = 75 + 80 + 85 / 3;
            Console.WriteLine("Percentage="+student.per);
        }
    }
}
