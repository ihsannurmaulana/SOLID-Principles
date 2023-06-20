using System;
using Microsoft.Extensions.DependencyInjection;

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

// Implementasi modul tingkat rendah untuk mesin pesawat
public class PlaneEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Plane engine started.");
    }

    public void Stop()
    {
        Console.WriteLine("Plane engine stopped.");
    }
}

// CheckEngine untuk memeriksa keadaan mesin
public class CheckEngine
{
    private readonly IEngine _engine;

    public CheckEngine(IEngine engine)
    {
        _engine = engine;
    }

    public void Check()
    {
        _engine.Start();
        _engine.Stop();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membangun DI Container
        var serviceProvider = new ServiceCollection()
            .AddTransient<IEngine, CarEngine>() // Registrasi implementasi CarEngine
            .AddTransient<IEngine, MotorcycleEngine>() // Registrasi implementasi MotorcycleEngine
            .AddTransient<IEngine, PlaneEngine>() // Registrasi implementasi PlaneEngine
            .BuildServiceProvider();

        // Mendapatkan instance CarEngine dari DI Container
        var carEngine = serviceProvider.GetService<IEngine>();

        // Menggunakan CarEngine
        carEngine.Start();
        carEngine.Stop();

        Console.WriteLine();

        // Mendapatkan instance MotorcycleEngine dari DI Container
        var motorcycleEngine = serviceProvider.GetService<IEngine>();

        // Menggunakan MotorcycleEngine
        motorcycleEngine.Start();
        motorcycleEngine.Stop();

        Console.WriteLine();

        // Mendapatkan instance PlaneEngine dari DI Container
        var planeEngine = serviceProvider.GetService<IEngine>();

        // Menggunakan PlaneEngine
        planeEngine.Start();
        planeEngine.Stop();

        Console.WriteLine();

        // CheckEngine untuk CarEngine
        var checkEnginePlane = serviceProvider.GetService<CheckEngine>();

        Console.ReadLine();
    }
}