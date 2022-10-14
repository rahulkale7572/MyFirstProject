using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oop
{
    class Box
    {
        public int height;
        public int width;
        public int length;
        public int area;

        static void Main(string[] args)
        {
            Box box = new Box();
            box.height = 5;
            box.width = 4;
            box.length = 3;
            box.area = box.height * box.width * box.length;

            Console.WriteLine("Area of Box="+box.area);

        }
    }
}
