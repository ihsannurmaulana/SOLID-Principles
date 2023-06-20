using System;

public class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Engine started");
    }

    public virtual void Accelerate()
    {
        Console.WriteLine("Vehicle accelerated");
    }
}