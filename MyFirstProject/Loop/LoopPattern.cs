using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loop
{
   /* *****
      *****
      *****
      *****
      *****  */
    class LoopPattern
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern1
    {/*
        *
        **
        ***
        ****
        *****    */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern4
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class NumberPattern1
    {/*
        1
        12
        123
        1234
        12345 */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class NumberPattern2
    {
     /* 1
        22
        333
        4444
        55555 */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class NumberPattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
