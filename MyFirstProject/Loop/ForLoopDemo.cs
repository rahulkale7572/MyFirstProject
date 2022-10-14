using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loop
{
    class ForLoopDemo
    {//print 1 to 10 numbers
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ForLoopDemo1
    {//WAP to print first 10 numbers in reverse order
        static void Main(string[] args)
        {
            for(int i=10;i>=1;i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ForLoopDemo2
    {/*wap to print 10 elements as below
        1,3,5,7,9,11,13,15,17,19*/
        static void Main(string[] args)
        {
            for (int i = 1; i <= 19; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ForLoopDemo3
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.Write("\n\n");
            Console.Write("Find sum of first 10 numbers:\n");
            Console.Write(".................................");
            Console.Write("\n\n");


            Console.Write("The first 10 numbers are:\n");
            for(i=1;i<=10;i++)
            {
                sum = sum + i;
                Console.Write("{0} ",i);
            }
            Console.Write("\nThe sum is:{0}\n", sum);
        }
    }
    class ForLoopDemo4
    {//Find sum of even numbers between 1 to 30
        static void Main(string[] args)
        { int sum = 0;
            for (int i = 2; i <= 30; i+=2)
            {
                sum = sum + i;
                Console.Write(i);
            }
            Console.WriteLine("The sum is:", sum);
        }
    }
    class ForLoopDemo5
    {//Write a number between 35 to 75
        static void Main(string[] args)
        {
            for(int i=35;i<=75;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ForLoopDemo6
    {//display number between 66 to 25
        static void Main(string[] args)
        {
            for(int i=66;i>=25;i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ForLoopDemo7
    {//wap to print 10 elements as below
        //1,3,5,7,9,11,13,15,16,17,19
        static void Main(string[] args)
        {
            for(int i=1;i<=19;i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ForLoopDemo8
    {//WAP to print 2,4,6,8,10,12,14,16,18
        static void Main(string[] args)
        {
            for (int i =2; i <= 18; i=i+2)
            {

                Console.WriteLine(i);
            }
        }
    }
    class ForLoopDemo9
    {//Take base and exponent value from user and find power of number:
        static void Main(string[] args)
        {
            int power = 1;
            Console.WriteLine("Enter Base");
            int Base =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Exponent");
            int Exponent = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Exponent; i++)
                power = power * Base;
            {
                Console.WriteLine(power);
            }
        }
    }
    class ForLoopDemo10
    {//Find factorial of a number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
                Console.WriteLine("Factorial of a number=" + fact);
            }
        }
    }
    class ForLoopDemo11
    {//find sum of numbers
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Sum of number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;
                Console.WriteLine("Sum of Number= "+ sum);
                i++;
            }
        }
    }
    class ForLoopDemo12
    {
        static void Main(string[] args)
        {//sum for loop
            int sum = 0;
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
                sum = sum + i;
            {
                Console.WriteLine("Sum of given number=" + sum);
            }
        }
    }
    class ForLoopDemo13
    {//sum of even number
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i = i + 2)
                sum = sum + i;
            {
                Console.WriteLine("Sum of Even Number=" + sum);
            }
        }
    }
    class ForLoopDemo14
    {//
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i=i+2)
            {
                Console.Write(i) ;
            }
        }
    }
    class ForLoopDemo15
    {//print the series 1,3,7,15
        static void Main(string[] args)
        {
            int p = 2;
            for(int i=1;i<=50;)
            {
                i = i + p;
                p = p * 2;
                Console.WriteLine(i);
            }
        }
    }
    class ForLoopDemo16
    {//print series 1,4,9,16
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i * i);
            }
        }
    }
    class ForLoopDemo17
    {//program to print table of given number
        static void Main(string[] args)
        {
            Console.WriteLine("enter to print table of given number");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                Console.WriteLine(i * num);
            }
        }
    }
}
