using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{//To check character is Novel 
    class IfElseIfLadderDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='e')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='i')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='o')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
    class IfElseIfLadderDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'E')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'I')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'O')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
    class IfElseIfDemo2
    {//To check given number is positive,negative or zero
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("Number is positive");
            }
            else if(num==0)
            {
                Console.WriteLine("Number is zero");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

        }
    }
    class IfElseIfDemo3
    { //To check given character is alphabet or digit or special character:
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a char");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "char is alphabet");
            }
            else if(ch>=0 && ch<=9)
            {
                Console.WriteLine(ch + "char is digit");
            }
            else
            {
                Console.WriteLine(ch + "is a special character");
            }
            

        }
    }
    class IfElseIfDemo4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My age");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("My freind age");
            int b = int.Parse(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("Hii");
            }
            else if(a<b)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How Are You");
            }
        }
    }
    class IfElseIfDemo5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if(num%3==0)
            {
                Console.WriteLine("Number is divisible by 3");
            }
            else if(num%9==0)
            {
                Console.WriteLine("Number is divisible by 9");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }
        }
    }
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int magicnumber = 45;
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            if (num < magicnumber)
            {
                Console.WriteLine("Number is less plz try again");
         
            }
            else if (num > magicnumber)
            {
                Console.WriteLine("Number is grather plz try again");
                
            }
            else
            {
                Console.WriteLine("guessing number is correct...thank you");
            
            }
        }
    }
}
