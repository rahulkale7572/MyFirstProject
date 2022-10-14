using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{
    class EvenOdd
    {//WAP to check whether a number is even or odd
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
