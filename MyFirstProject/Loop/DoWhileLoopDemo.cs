using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loop
{
    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp= num;

            while(num<0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
        }
    }
}
