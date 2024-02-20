using System.Security.Cryptography;

namespace MultiiCast_Delegates;
public delegate void calculation(int a, int b);

class Program
{
    public static void addition(int a, int b)
    {
        var result = a + b;
        Console.WriteLine("Addition is " + result);
    }
    public static void substraction(int a, int b)
    {
        var result = a - b;
        Console.WriteLine("substraction is " + result);
    }
    public static void multiplcation(int a, int b)
    {
        var result = a * b;
        Console.WriteLine("multiplcation is " + result);
    }
    static void Main(string[] args)
    {
        calculation c = new calculation(addition);
        c += substraction;
        c += multiplcation;
        c -= multiplcation;
        c(150, 100);
    }
}

