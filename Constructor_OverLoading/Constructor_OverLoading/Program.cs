namespace Constructor_OverLoading;

class Program
{
    public Program()
    {
        Console.WriteLine("Default Constructor");
    }
    public Program(int a, int b)
    {
        Console.WriteLine("Addition of two numbers:{0}",(a+b));
    }
    public Program(int a, int b, int c)
    {
        Console.WriteLine("Addition of three numbers:{0}",(a+b+c));
    }
    static void Main(string[] args)
    {
        Program p1 = new Program();
        Program p2 = new Program(10, 12);
        Program p3 = new Program(10, 20, 30);
    }
}

