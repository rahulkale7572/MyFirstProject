using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oop
{
    class Employee
    {
        public int eid;
        public string name;
        public int salary;

        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.eid=300;
            emp1.name = "Akshay";
            emp1.salary = 35000;
            Console.WriteLine(emp1.eid+" "+emp1.name+" "+emp1.salary);
        }
    }
}
