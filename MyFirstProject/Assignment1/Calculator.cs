using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{//WAP to create simple calculator
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine(("Enter Choice(1-4)"));
            int ch = Convert.ToChar(Console.ReadLine());
            int A, B, C;
            if (ch == 1)
            {
                Console.Write("Enter A");
                A = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter B");
                B = Convert.ToChar(Console.ReadLine());
                C = A + B;
                Console.WriteLine("Sum = {0}",C);
            }
            else if (ch == 2)
            {
                Console.Write("Enter A");
                A = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter B");
                B = Convert.ToChar(Console.ReadLine());
                C = A - B;
                Console.WriteLine("Difference = {0}", C);
            }
            else if (ch == 3)
            {
                Console.Write("Enter A");
                A = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter B");
                B = Convert.ToChar(Console.ReadLine());
                C = A * B;
                Console.WriteLine("Product = {0}", C);
            }
            else if (ch == 4)
            {
                Console.Write("Enter A");
                A = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter B");
                B = Convert.ToChar(Console.ReadLine());
                C = A / B;
                Console.WriteLine("Quotient = {0}", C);
            }
            else
            {
                Console.WriteLine("Invalid Key");
            }
            Console.ReadLine();
        }
    }
}
