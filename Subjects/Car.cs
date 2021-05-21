using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public double EngCapacity { get; set; }

        public int HorsePower { get; set; }

        public string Type { get; set; }

        public string Condition { get; set; }

        public int Price { get; set; }

        public int Year { get; set; }

        public string base64image { get; set; }

        public int Mileage { get; set; }

        public string Origin { get; set; }

        public Car(string make, string model, double cap, int hp, string type, string cond, int price, int year, int mileage, string origin)
        {
            Make = make;
            Model = model;
            EngCapacity = cap;
            HorsePower = hp;
            Type = type;
            Condition = cond;
            Price = price;
            Year = year;
            Mileage = mileage;
            Origin = origin;
        }

        public bool Compare(Car car)
        {
            return car.Make == Make && car.Model == Model && car.EngCapacity == EngCapacity && car.HorsePower == HorsePower && car.Type == Type && car.Condition == Condition && car.Price == Price && car.Year == Year;
        }

        public int CompareTo(object obj)
        {
            Car objCar = obj as Car;
            return this.Make.CompareTo(objCar.Make);
        }
    }

    public class CarOperation
    {
        public Car Car;
        public bool IsSold;
        public DateTime Time;

        public CarOperation(Car car, bool isSold)
        {
            Car = car;
            IsSold = isSold;
            Time = DateTime.Now;
        }
    }
}
