using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{//WAP to input anhy char and check whether it is alphabet,digit or special char
    class Check
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a char");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " char is alphabet");
            }
            else if (ch >= 0 && ch <= 9)
            {
                Console.WriteLine(ch + " char is digit");
            }
            else
            {
                Console.WriteLine(ch + " is a special character");
            }
        }
    }
}
