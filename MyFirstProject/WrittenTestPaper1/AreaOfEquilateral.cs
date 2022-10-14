using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicTest1
{
    class AreaOfEquilateral
    {
        static void Main(string[] args)
        {
            double area;
            Console.WriteLine("Enter Side");
            int a = int.Parse(Console.ReadLine());
            area =(1.73 * a * a) / 4;
            Console.WriteLine("Area of Equilateral Triangle is:"+area);
        }
    }
}
