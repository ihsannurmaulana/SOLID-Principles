using System;

// Interface Segregation Principle (ISP)
// Interfaces should be specific and clients should not be forced to depend on interfaces they do not use.

// Bad example without using ISP
public interface IVehicle
{
    void Start();
    void Stop();
    void Accelerate();
    void Brake();
}

public class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    public void Accelerate()
    {
        Console.WriteLine("Car accelerating.");
    }

    public void Brake()
    {
        Console.WriteLine("Car braking.");
    }
}

public class Motorcycle : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Motorcycle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Motorcycle stopped.");
    }

    public void Accelerate()
    {
        Console.WriteLine("Motorcycle accelerating.");
    }

    public void Brake()
    {
        Console.WriteLine("Motorcycle braking.");
    }
}

public class Driver
{
    private IVehicle vehicle;

    public void SetVehicle(IVehicle vehicle)
    {
        this.vehicle = vehicle;
    }

    public void Drive()
    {
        vehicle.Start();
        vehicle.Accelerate();
        vehicle.Brake();
        vehicle.Stop();
    }
}

// Good example using ISP
public interface IStartable
{
    void Start();
}

public interface IStoppable
{
    void Stop();
}

public interface IAcceleratable
{
    void Accelerate();
}

public interface IBrakable
{
    void Brake();
}

public class Car2 : IStartable, IStoppable, IAcceleratable, IBrakable
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    public void Accelerate()
    {
        Console.WriteLine("Car accelerating.");
    }

    public void Brake()
    {
        Console.WriteLine("Car braking.");
    }
}

public class Motorcycle2 : IStartable, IStoppable, IAcceleratable, IBrakable
{
    public void Start()
    {
        Console.WriteLine("Motorcycle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Motorcycle stopped.");
    }

    public void Accelerate()
    {
        Console.WriteLine("Motorcycle accelerating.");
    }

    public void Brake()
    {
        Console.WriteLine("Motorcycle braking.");
    }
}

public class Driver2
{
    private IStartable startableVehicle;
    private IAcceleratable acceleratableVehicle;
    private IBrakable brakableVehicle;
    private IStoppable stoppableVehicle;

    public void SetVehicle(IStartable startableVehicle, IAcceleratable acceleratableVehicle, IBrakable brakableVehicle, IStoppable stoppableVehicle)
    {
        this.startableVehicle = startableVehicle;
        this.acceleratableVehicle = acceleratableVehicle;
        this.brakableVehicle = brakableVehicle;
        this.stoppableVehicle = stoppableVehicle;
    }

    public void Drive()
    {
        startableVehicle.Start();
        acceleratableVehicle.Accelerate();
        brakableVehicle.Brake();
        stoppableVehicle.Stop();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bad example without using ISP:");
        IVehicle car = new Car();
        Driver driver1 = new Driver();
        driver1.SetVehicle(car);
        driver1.Drive();

        Console.WriteLine();

        IVehicle motorcycle = new Motorcycle();
        Driver driver2 = new Driver();
        driver2.SetVehicle(motorcycle);
        driver2.Drive();

        Console.WriteLine();
        Console.WriteLine("Good example using ISP:");

        Car2 car2 = new Car2();
        Motorcycle2 motorcycle2 = new Motorcycle2();
        Driver2 driver3 = new Driver2();
        driver3.SetVehicle(car2, car2, car2, car2);
        driver3.Drive();

        Console.WriteLine();

        driver3.SetVehicle(motorcycle2, motorcycle2, motorcycle2, motorcycle2);
        driver3.Drive();
    }
}
