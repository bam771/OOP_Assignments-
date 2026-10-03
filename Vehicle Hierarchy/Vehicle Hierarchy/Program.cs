using System;

public class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine($"{Brand} ({Year}) is starting... Vroom!");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }
}

public class Bus : Vehicle
{
    public int Capacity;

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Capacity = capacity;
    }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", 2022, 4);
        Bus myBus = new Bus("Mercedes", 2018, 50);
        Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", 2021, false);

        Console.WriteLine("--- Testing Start() Method on All Vehicles ---");
        myCar.Start();
        myBus.Start();
        myMotorcycle.Start();
    }
}
