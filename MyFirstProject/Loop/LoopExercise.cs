using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loop
{
    class LoopExercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime = true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
    class AmrstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  Number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            Console.WriteLine(sum + " "+num);
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("Number is Amrstrong");
            }
            else
            {
                Console.WriteLine("Not");
            }
        }
    }
}
