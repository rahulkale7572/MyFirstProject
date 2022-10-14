using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loop
{
    class Series1
    {
        static void Main(string[] args)
        {// 0,7,26,63,...display series till 10 numbers
            static void Main(string[] args)
            {
                int num;
                for (int i = 1; i <= 10; i++)
                {
                    num = ((i * i * i) - 1);
                    Console.WriteLine(num);
                }
            }
        }
    }
    class Serie2
    { //1,8,27,64...
        static void Main(string[] args)
        {
            int cube;
            for(int i = 1; i <= 10; i++)
            {
                cube = i * i * i;
                Console.WriteLine(cube);
            }
        }
    }
    class Series3
    {
        static void Main(string[] args)
        {

        }
    }
}
