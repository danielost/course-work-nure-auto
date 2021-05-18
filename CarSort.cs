using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    public static class CarSort
    {
        public static void BubbleSortPriceAsc(List<Car> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j].Price < arr[j + 1].Price)
                    {
                        // swap temp and arr[i]
                        Car temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        public static void BubbleSortPriceDesc(List<Car> arr)
        {
            
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j].Price > arr[j + 1].Price)
                    {
                        // swap temp and arr[i]
                        Car temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        public static void BubbleSortNameAsc(List<Car> arr)
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

        public static void BubbleSortNameDesc(List<Car> arr)
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
