namespace Delegate_Demo;

public delegate void Calculation(int a, int b);

class Program
{
    public static void Addtion(int a, int b)
    {
        var result = a + b;
        Console.WriteLine("Addition is: {0}",result);
    }

    public static  void substraction(int a, int b)
    {
        var result = a - b;
        Console.WriteLine("Substraction is: {0}", result);
    }
    static void Main(string[] args)
    {
        Calculation obj = new Calculation(Program.Addtion);
        obj(12, 15);
        obj = substraction;
        obj (20, 10);
    }
}

