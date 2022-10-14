using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class SquarOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Square of number is"+ num * num);
        }
    }
}
