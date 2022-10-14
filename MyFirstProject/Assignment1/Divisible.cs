using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{//WAP to check whether a number is divisible by 5 and 11 or not
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("Number is Divisible by 5");
            }
            else if (num % 9 == 0)
            {
                Console.WriteLine("Number is Divisible by 9");
            }
            else
            {
                Console.WriteLine("Number is not Divisible");
            }
        }
    }
}
