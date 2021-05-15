using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public double EngCapacity { get; set; }

        public int HorsePower { get; set; }

        public string Type { get; set; }

        public string Condition { get; set; }

        public int Price { get; set; }

        public Car(string make, string model, double cap, int hp, string type, string cond, int price)
        {
            Make = make;
            Model = model;
            EngCapacity = cap;
            HorsePower = hp;
            Type = type;
            Condition = cond;
            Price = price;
        }
    }
}
