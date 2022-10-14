using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class Cube
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = int.Parse(Console.ReadLine());
            int result = a * a * a;
            Console.WriteLine(result);
        }
    }
}
