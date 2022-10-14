using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{//WAP to find maximum between three numbers
    class MaximumNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is Greather");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is not Greather");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("num3 is Greather");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
