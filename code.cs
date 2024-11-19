using System;

namespace HomeWorkVehicle
{
    public class Vehicle
    {
        public virtual void StartMoving()
        {
            Console.WriteLine("Vehicle is starting to move");
        }
    }

    public class Car : Vehicle
    {
        public override void StartMoving()
        {
            Console.WriteLine("Car is starting to drive");
        }
    }

    public class Bike : Vehicle
    {
        public override void StartMoving()
        {
            Console.WriteLine("Bike is starting to Pa Zadan :D");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car();
            Vehicle myBike = new Bike();

            myCar.StartMoving();
            myBike.StartMoving();
            Console.ReadKey();
        }
    }
}
