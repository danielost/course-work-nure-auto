using System;
using System.Collections.Generic;
using System.Text;

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

        private int year;

        public int Year { get
            {
                return year;
            }
            set
            {
                if (value < 2022 && value > 1070)
                {
                    year = value;
                }
            }
        }

        public Car(string make, string model, double cap, int hp, string type, string cond, int price, int year)
        {
            Make = make;
            Model = model;
            EngCapacity = cap;
            HorsePower = hp;
            Type = type;
            Condition = cond;
            Price = price;
            Year = year;
        }
    }
}
