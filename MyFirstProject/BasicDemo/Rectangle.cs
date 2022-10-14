using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class Rectangle
    {// Write a program to enter length and breadth of a rectangle and find its area
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            int b = int.Parse(Console.ReadLine());
            int Area = l * b;
            Console.WriteLine("Area of rectangle is" + Area);
        }
    }
}
