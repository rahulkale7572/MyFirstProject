using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{//WAP to check whether a number is negative,positive or zero
    class NumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (num == 0)
            {
                Console.WriteLine("Number is zero");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
    }
}
