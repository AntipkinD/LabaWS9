using System;
using System.Collections;
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
        
    }
    internal class Garage
    {
        internal protected List<Car> garageCollection = new List<Car>();
        public void getInfo(Car car)
        {
            Console.WriteLine($"Машина {car.Mark}, с номером {car.Number}, она загрязнена на {car.Pollution} %");
        }
        public void getMyCars()
        {
            foreach (Car i in this.garageCollection)
                getInfo(i);
        }
        public int getQuantity()
        {
            return this.garageCollection.Count;
        }
        public void setCars(params Car[] cars)
        {
            foreach(Car i in cars)
            this.garageCollection.Add(i);
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
