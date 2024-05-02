using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaWS9
{
    internal class Car
    {
        internal protected string Mark { get; private set; }
        internal protected string Number { get; private set; }
        internal int Pollution { get; set; }
        public Car()
        {
            Mark = "Undefined";
            Number = "ОО000О";
            Pollution = 100;
        }
        public Car(string mark, string number)
        {
            Mark = mark;
            Number = number;
            Pollution = new Random().Next(0, 101);
        }
        public void getInfo()
        {
            Console.WriteLine($"Машина {Mark}, с номером {Number}, она загрязнена на {Pollution} %");
        }
    }
    internal class Garage
    {
        public void Stay(Car car)
        {
            car.Pollution += new Random().Next(0, 2);
            Console.WriteLine($"Машина {car.Mark} стоит в гараже, она загрязнена на {car.Pollution} %");
        }
    }
    internal class Washer
    {
        public void Wash(Car car)
        {
            car.Pollution = 0;
            Console.WriteLine($"Машина {car.Mark} помыта, теперь она загрязнена на {car.Pollution} %");
        }
    }
}
