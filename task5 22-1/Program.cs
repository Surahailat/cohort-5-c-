

using System;

namespace task5_22_1
{
    class Vehicle //sealed
    {

        public string Brand { get; set; }
        public string Model { get; set; }

        public void Start() //method
        {
            Console.WriteLine("Vehicle is starting");
        }
    }
    class Car : Vehicle {
        public int NumberOfDoors;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Start();
            Car car = new Car();
            car.Brand = "BMW";
            car.Model = "2012";
            car.NumberOfDoors = 4;
            



        }
    }
}
