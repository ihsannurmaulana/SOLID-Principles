// Interface Segregation Principle (ISP)
// Interfaces should be specific and clients should not be forced to depend on interfaces they do not use.

// Bad example without using ISP
public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class Worker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

public class Manager
{
    private IWorker worker;

    public void SetWorker(IWorker worker)
    {
        this.worker = worker;
    }

    public void Manage()
    {
        worker.Work();
    }
}

// Good example using ISP
public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public interface ISleepable
{
    void Sleep();
}

public class Worker2 : IWorkable, IEatable, ISleepable
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

public class Manager2
{
    private IWorkable worker;

    public void SetWorker(IWorkable worker)
    {
        this.worker = worker;
    }

    public void Manage()
    {
        worker.Work();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bad example without using ISP:");
        IWorker worker1 = new Worker();
        Manager manager1 = new Manager();
        manager1.SetWorker(worker1);
        manager1.Manage();

        Console.WriteLine();

        Console.WriteLine("Good example using ISP:");
        IWorkable worker2 = new Worker2();
        Manager2 manager2 = new Manager2();
        manager2.SetWorker(worker2);
        manager2.Manage();
    }
}
