using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loop
{
    class WhileLoopDemo
    {// Write a number between 35 to 75
        static void Main(string[] args)
        {
            int i = 35;
            while (i <= 75)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    class WhileLoopDemo1
    {//Display number between 66 to 25
        static void Main(string[] args)
        {
            int i = 66;
            while (i > 25)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
    class WhileLoopDemo2
    {//factorial
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            int i = 1;
            while (i <= num)
            {
                fact = fact * i;
                Console.WriteLine(fact);
                i++;
            }
        }
    }
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            int fact = 1;
            while (i <= num)
            {
                fact = fact * i;
                Console.WriteLine(fact);
                i++;
            }
        }
    }
    class Sum
    {//
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while (i <= num)
            {
                sum = sum + i;
                Console.WriteLine(sum);
                i++;
            }
        }
    }
    class Demo1
    { //WAP to print 1 to 10 numbers
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while (i<= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    class Demo2
    {//WAP to 1 to 10 numbers in reverse order
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=int.Parse(Console.ReadLine());
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
    class Demo3
    {
        static void Main(string[] args)
        {/*wap to print 10 elements as below
            1,3,5,7,9,11,13,15,17,19*/
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 19)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
    }
    class Demo4
    {
        static void Main(string[] args)
        { /* //Find sum of even numbers between 1 to 30
            Console.WriteLine("Enter Number :");
            int num = int.Parse(Console.ReadLine());
            int i = 2;
            int sum = 0;
            while (i <= num)
            {
                sum = sum + i;
                Console.WriteLine(sum);
                i++;
            }*/

        }
    }
class Demo5
    {  /*wap to print 10 elements as below
        1,3,5,7,9,11,13,15,17,19*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 19)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
    }
    class Demo6
    {//WAP to print 2,4,6,8,10,12,14,16,18
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int i= 2;
            while (i<= 18)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
    }
    class Demo7
    { //Take base and exponent value from user and find power of number:
        static void Main(string[] args)
        {
          /*  Console.WriteLine("Base");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Exponent");
            int Exponent = int.Parse(Console.ReadLine());
            int i = 1;
            int power = 1;
            while (i <= Exponent)
                power = power * Base;
            {
                Console.WriteLine(power);
                i++;
            }*/
        }
    }
    class Demo8
    {//Find factorial of a number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            int fact = 1;
            while (i <= num)
            {
                fact = fact * i;
                Console.WriteLine(fact);
                i++;
            }
        }
    }
    class Demo9
    {//find sum of numbers
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;
            while (i <= num)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
    }
}

