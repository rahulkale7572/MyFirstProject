using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Excercises
{
    class Eg1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Red Colour");
            }
            else if (num > 2 && num < 8)
            {
                Console.WriteLine("Green Colour");
            }
            else if (num % 2 == 1)
            {
                Console.WriteLine("Black Colour");
            }
            else if (num % 2 == 1 && num > 8) 
            {
                Console.WriteLine("White Colour");
            }
        }
    }
}
