// Interface Segregation Principle (ISP)
// Interface harus spesifik dan klien tidak boleh dipaksa bergantung pada interface yang tidak mereka gunakan.

// Tanpa menggunakan ISP
public interface IVehicle
{
    void Start();
    void Stop();
    void Brake();
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
    public void Brake()
    {
        Console.WriteLine("Car braking.");
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

    public void Brake()
    {
        Console.WriteLine("Ships braking.");
    }

    public void Wheel()
    {
        Console.WriteLine("Ships do not use wheels");
    }
}



// Menggunakan ISP
public interface ILand
{
    void Wheel();

}

public interface ISea
{
    void Start();
    void Stop();
    void Brake();
}


public class Car1 : ILand, ISea
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }
    public void Stop()
    {
        Console.WriteLine("Car stopped");
    }
    public void Brake()
    {
        Console.WriteLine("Car braking");
    }
    public void Wheel()
    {
        Console.WriteLine("Car using wheel");
    }
}

public class Ships1 : ISea
{
    public void Start()
    {
        Console.WriteLine("Ship started");
    }
    public void Stop()
    {
        Console.WriteLine("Ship stopped");
    }
    public void Brake()
    {
        Console.WriteLine("Ship braking");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Tanpa menggunakan ISP:");
        IVehicle car = new Car();
        car.Start();
        car.Stop();
        car.Brake();
        car.Wheel();

        IVehicle ships = new Ships();
        ships.Start();
        ships.Stop();
        ships.Brake();
        ships.Wheel();

        Console.WriteLine();

        Console.WriteLine("Menggunakan ISP:");
        ILand car1 = new Car1();
        car1.Wheel();
        ISea carAsSea = (ISea)car1;
        carAsSea.Start();
        carAsSea.Stop();
        carAsSea.Brake();

        ISea ships1 = new Ships1();
        ships1.Start();
        ships1.Stop();
        ships1.Brake();

    }
}
