using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicTest1
{
    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int total = a + b + c + d + e;
            float average = total / 5f;
            float percentage = average * 100;
            Console.WriteLine("Total Marks=" + total);
            Console.WriteLine("Total Average=" + average);
            Console.WriteLine("Total Average=" + percentage);

        }
    }
}
