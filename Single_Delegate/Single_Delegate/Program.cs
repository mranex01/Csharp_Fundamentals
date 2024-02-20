using System.Runtime.InteropServices;

namespace Single_Delegate;
public delegate void Calculation(int a, int b);
class Program
{

    public static void Addition ( int a, int b)
    {
        var result = a + b;
        Console.WriteLine("Addition is {0}",result);
    }
    static void Main(string[] args)
    {
        Calculation obj = new Calculation(Program.Addition);
        obj(10, 20);
    }
}

