using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{/*WAP to check whether entered number is 3digit no.then do sum of 1st and 3rd digit and print 
   sum*/
    class Check1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            if (num < 1000 && num > 99)
            {
                Console.WriteLine("Number is 3 digit number");
            }
            else
            {
                Console.WriteLine("Number is not 3 digit number");
            }
        }
    }
}
