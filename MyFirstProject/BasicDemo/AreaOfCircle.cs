using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Radius");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = 3.14*r * r;
            Console.WriteLine("Area of Circle " + area);
        }
    }
}
