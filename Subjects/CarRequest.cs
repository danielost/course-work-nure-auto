using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    public class CarRequest
    {
        public List<Car> requestedCars { get; set; }
        public bool isChanged { get; private set; }
        public string SupplierLogin { get; private set; }

        public CarRequest(string login)
        {
            requestedCars = new List<Car>();
            isChanged = false;
            SupplierLogin = login;
        }

        public void AddCar(Car car)
        {
            requestedCars.Add(car);
        }

        public void ChangeCar(Car current, Car toChange)
        {
            for (int i = requestedCars.Count - 1; i >= 0; i--)
            {
                if (current.Compare(requestedCars[i]))
                {
                    requestedCars[i] = toChange;
                    isChanged = true;
                    return;
                }
            }          
        }
    }
}
