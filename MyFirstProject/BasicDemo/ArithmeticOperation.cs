using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class ArithmeticOperation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition " + (x + y));
            Console.WriteLine("Substraction " + (x - y));
            Console.WriteLine("Multiplication " + (x * y));
            Console.WriteLine("Division " + (x / y));
            Console.WriteLine("Modulus " + (x % y));
        }
    }
}
