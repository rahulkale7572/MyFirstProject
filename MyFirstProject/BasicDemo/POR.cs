using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class POR
    {//Write a program to enter base and breadth of a rectangle and find its perimeter.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of Rectangle");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perimeter of rectangle=" + 2 * (1 + w));
        }
    }
}
