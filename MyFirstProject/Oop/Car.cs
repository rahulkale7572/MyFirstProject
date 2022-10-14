using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oop
{
    class Car
    {
        public string carcolour;
        public string carbrand;
        public int modelno;
        public int price;

        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.carcolour = "Red";
            car1.carbrand = "Ford";
            car1.modelno = 7575;
            car1.price=1000000;

            Console.WriteLine(car1.carcolour+" "+car1.carbrand+" "+car1.modelno+" "+car1.price);


            Car car2 = new Car();
            car2.carcolour = "Black";
            car2.carbrand = "Ford";
            car2.modelno = 9765;
            car2.price = 800000;

            Console.WriteLine(car2.carcolour + " " + car2.carbrand + " " + car2.modelno + " " + car2.price);


            Car car3 = new Car();
            car3.carcolour = "BLack & White";
            car3.carbrand = "Ford";
            car3.modelno = 0101;
            car3.price = 1100000;

            Console.WriteLine(car3.carcolour + " " + car3.carbrand + " " + car3.modelno + " " + car3.price);
        }
    }
}
