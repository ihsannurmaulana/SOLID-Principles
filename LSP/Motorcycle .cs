﻿using System;

public class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine started");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Motorcycle accelerated");
    }
}
