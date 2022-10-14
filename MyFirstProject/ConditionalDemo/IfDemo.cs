using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{//to check num1<num2:
    class IfLoopDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine(num1 +"  is greather");
            }
            else
            {
                Console.WriteLine(num2 + " is greather");
            }
        }
    }
}
