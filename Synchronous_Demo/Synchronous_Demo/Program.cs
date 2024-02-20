namespace Synchronous_Demo;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();

        Console.ReadLine();
    }

    public static void Task1()
    {
        Console.WriteLine("Starting Task 1 ");
        Thread.Sleep(3000);
        Console.WriteLine("End Task 1");
    }

    public static void Task2()
    {
        Console.WriteLine("Starting Task 2 ");
        Thread.Sleep(2000);
        Console.WriteLine("End Task 2");
    }

    public static void Task3()
    {
        Console.WriteLine("Starting Task 3 ");
        Thread.Sleep(1000);
        Console.WriteLine("End Task 3");
    }

    public static void Task4()
    {
        Console.WriteLine("Starting Task 4 ");
        Thread.Sleep(4000);
        Console.WriteLine("End Task 4");
    }
}

