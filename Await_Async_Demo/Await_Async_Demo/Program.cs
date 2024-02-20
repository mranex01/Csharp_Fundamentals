
using System.Threading.Tasks;

namespace Await_Async_Demo;

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

    public async static void Task1()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Starting Task 1 ");
            Thread.Sleep(3000);
            Console.WriteLine("End Task 1");
        });

    }

    public async static void Task2()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Starting Task 2 ");
            Thread.Sleep(2000);
            Console.WriteLine("End Task 2");
        });

    }

    public async static void Task3()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Starting Task 3 ");
            Thread.Sleep(1000);
            Console.WriteLine("End Task 3");
        });

    }

    public async static void Task4()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Starting Task 4 ");
            Thread.Sleep(4000);
            Console.WriteLine("End Task 4");
        });

    }
}

