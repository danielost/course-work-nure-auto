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

        private int year;

        public string base64image { get; set; }

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

        public bool Compare(Car car)
        {
            return car.Make == Make && car.Model == Model && car.EngCapacity == EngCapacity && car.HorsePower == HorsePower && car.Type == Type && car.Condition == Condition && car.Price == Price && car.Year == Year;
        }

        
    }
}
