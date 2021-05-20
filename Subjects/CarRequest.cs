using System;
using System.Collections.Generic;
using System.IO;
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

        public void WriteLogin(string login)
        {
            string name = "supplierLogin.txt";
            string path = Path.Combine(Environment.CurrentDirectory, name);

            File.WriteAllText(path, login);
        }

        public string ReadLogin()
        {
            string name = "supplierLogin.txt";
            string path;
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, name)))
            {
                path = Path.Combine(Environment.CurrentDirectory, name);
                return File.ReadAllText(path);
            }
            else    
            {
                return "";
            }           
        }
    }
}
