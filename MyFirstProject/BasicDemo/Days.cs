using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicDemo
{
    class Days
    {
        static void Main(string[] args)
        {
            int ndays, years, weeks, days;
            Console.WriteLine("Enter the number of days");
            ndays = int.Parse(Console.ReadLine());
            years = ndays % 365;
            weeks = (ndays % 365) / 7;
            days = ndays = 365;
            Console.WriteLine("{0} is equivalent to {1}years,{2}week,{3}days");
            Console.ReadLine();
        }
    }
}
