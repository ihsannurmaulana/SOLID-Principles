using System;
using System.Runtime.ConstrainedExecution;

public class Program
{
    public static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();
        Car car = new Car();
        Motorcycle motorcycle = new Motorcycle();

        StartAndAccelerateVehicle(vehicle);
        StartAndAccelerateVehicle(car);
        StartAndAccelerateVehicle(motorcycle);

        Console.ReadLine();
    }

    public static void StartAndAccelerateVehicle(Vehicle vehicle)
    {
        vehicle.StartEngine();
        vehicle.Accelerate();
    }
}
