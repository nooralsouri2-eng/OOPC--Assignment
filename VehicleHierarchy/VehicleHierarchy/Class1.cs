using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleHierarchy
{
    // Base Class
    public class Vehicle
    {
        public string Brand;
        public int Year;

        // Constructor 
        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        // Start()
        public void Start()
        {
            Console.WriteLine(Brand +" "+ Year +" "+ "Is Starting!");
        }
    }

    // Car Class
    public class Car : Vehicle
    {
        public int NumberOfDoors;

        // base(...)
        public Car(string brand, int year, int numberOfDoors) : base(brand, year)
        {
            NumberOfDoors = numberOfDoors;
        }
    }

    // Bus
    public class Bus : Vehicle
    {
        public int Capacity;

        public Bus(string brand, int year, int capacity) : base(brand, year)
        {
            Capacity = capacity;
        }
    }

    // Motorcycle
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar;

        public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
        {
            HasSidecar = hasSidecar;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", 2022, 4);
            Bus myBus = new Bus("Volvo", 2018, 50);
            Motorcycle myMotorcycle = new Motorcycle("Yamaha", 2021, false);

            // Demonstrating Reaching to Start():
            myCar.Start();
            myBus.Start();
            myMotorcycle.Start();
        }
    }
}