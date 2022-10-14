using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class Swapping
    {
        static void Main(string[] args)
        {
            //swapping
            int a = 5, b = 3, temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values after swapping");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }   
    }
    class Swapping1
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Values after swapping");
            Console.WriteLine("a" + a);
            Console.WriteLine("b" + b);
        }
    }
}
