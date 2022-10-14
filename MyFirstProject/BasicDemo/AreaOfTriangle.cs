using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class AreaOfTriangle
    {//To calculate area of triangle
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Base");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Height");
            double h = Convert.ToDouble(Console.ReadLine());
            double area = (b*h)/2;
            Console.WriteLine("Area of Triangle " + area);

        }
    }
}
