using System;

// Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("== Vehicle Program ==");
        Console.WriteLine("1. Start Car");
        Console.WriteLine("2. Stop Car");
        Console.WriteLine("3. Start Motorcycle");
        Console.WriteLine("4. Stop Motorcycle");
        Console.WriteLine("5. Exit");

        IVehicle car = new Car(new CarEngine());
        IVehicle motorcycle = new Motorcycle(new MotorcycleEngine());

        bool exit = false;
        while (!exit)
        {
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    car.Start();
                    break;
                case "2":
                    car.Stop();
                    break;
                case "3":
                    motorcycle.Start();
                    break;
                case "4":
                    motorcycle.Stop();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

// Abstraksi untuk mesin kendaraan
public interface IEngine
{
    void Start();
    void Stop();
}

// Implementasi modul tingkat rendah untuk mesin mobil
public class CarEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Car engine started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car engine stopped.");
    }
}

// Implementasi modul tingkat rendah untuk mesin sepeda motor
public class MotorcycleEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Motorcycle engine started.");
    }

    public void Stop()
    {
        Console.WriteLine("Motorcycle engine stopped.");
    }
}

// Abstraksi untuk kendaraan
public interface IVehicle
{
    void Start();
    void Stop();
}

// Implementasi modul tingkat tinggi untuk mobil
public class Car : IVehicle
{
    private readonly IEngine _engine;

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        _engine.Stop();
        Console.WriteLine("Car stopped.");
    }
}

// Implementasi modul tingkat tinggi untuk sepeda motor
public class Motorcycle : IVehicle
{
    private readonly IEngine _engine;

    public Motorcycle(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Motorcycle started.");
    }

    public void Stop()
    {
        _engine.Stop();
        Console.WriteLine("Motorcycle stopped.");
    }

    //Console.WriteLine();
}