using System;

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
/*//Penerapan yang salah
public class Motorcycle : Vehicle
{
    public override void Accelerate()
    {
        Console.WriteLine("Motorcycle accelerated.");
    }

    public void Wheelie()
    {
        Console.WriteLine("Motorcycle doing a wheelie.");
    }
}
*/