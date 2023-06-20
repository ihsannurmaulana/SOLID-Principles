using System;

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Car accelerated");
    }
}