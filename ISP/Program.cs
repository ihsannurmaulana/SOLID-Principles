// Interface Segregation Principle (ISP)
// Interface harus spesifik dan klien tidak boleh dipaksa bergantung pada interface yang tidak mereka gunakan.

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Tanpa menggunakan ISP:");
        IVehicle car = new Car();
        car.Start();
        car.Stop();
        car.Wheel();

        IVehicle ships = new Ships();
        ships.Start();
        ships.Stop();
        ships.Wheel();

        Console.WriteLine();

        Console.WriteLine("Menggunakan ISP:");
        IVehicleLand car1 = new LandVehicle();
        car1.Wheel();
        IVehicleSea car2 = new LandVehicle();
        car2.Start();
        car2.Stop();

        IVehicleSea ships1 = new LandSea();
        ships1.Start();
        ships1.Stop();

    }
}
// Tanpa menggunakan ISP
public interface IVehicle
{
    void Start();
    void Stop();
    void Wheel();
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
    public void Wheel()
    {
        Console.WriteLine("Car using wheel");
    }
}

public class Ships : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Ships started.");
    }

    public void Stop()
    {
        Console.WriteLine("Ships stopped.");
    }

    public void Wheel()
    {
        Console.WriteLine("Ships do not use wheels");
    }
}



// Menggunakan ISP
public interface IVehicleLand
{
    void Wheel();

}

public interface IVehicleSea
{
    void Start();
    void Stop();
}

public class LandVehicle : IVehicleLand, IVehicleSea
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }
    public void Stop()
    {
        Console.WriteLine("Car stopped");
    }
    public void Wheel()
    {
        Console.WriteLine("Car using wheel");
    }
}

public class LandSea : IVehicleSea
{
    public void Start()
    {
        Console.WriteLine("Ship started");
    }
    public void Stop()
    {
        Console.WriteLine("Ship stopped");
    }
}


