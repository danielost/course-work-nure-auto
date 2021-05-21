using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork
{
    public class CarSort
    {
        public void BubbleSortPriceAsc(List<Car> arr)
        {
            //int n = arr.Count;
            //for (int i = 0; i < n - 1; i++)
            //    for (int j = 0; j < n - 1; j++)
            //        if (arr[j].Price < arr[j + 1].Price)
            //        {
            //            // swap temp and arr[i]
            //            Car temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }


            arr = arr.OrderBy(si => si.Price).ToList();
            //arr = arr.OrderByDescending(x => x.Year).ToList();
        }

        public void BubbleSortPriceDesc(List<Car> arr)
        {
            
            //int n = arr.Count;
            //for (int i = 0; i < n - 1; i++)
            //    for (int j = 0; j < n - 1; j++)
            //        if (arr[j].Price > arr[j + 1].Price)
            //        {
            //            // swap temp and arr[i]
            //            Car temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }

            arr = arr.OrderBy(si => si.Price).ToList();
            arr.Reverse();
        }

        public void BubbleSortNameAsc(List<Car> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j].Make.CompareTo(arr[j + 1].Make) > 0)
                    {
                        // swap temp and arr[i]
                        Car temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        public void BubbleSortNameDesc(List<Car> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j].Make.CompareTo(arr[j + 1].Make) < 0)
                    {
                        // swap temp and arr[i]
                        Car temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
    }
}
