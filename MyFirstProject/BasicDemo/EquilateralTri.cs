using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class EquilateralTri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a side");
            int a= int.Parse(Console.ReadLine());
            double area = (1.33 * a * a) / 4;
            Console.WriteLine("Area of equilateral triangle is " + area);
        }
    }
}
