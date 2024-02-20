namespace PassByOut;

class Program
{
    public static void PassbyOut(out int a)
    {
        a =  10;
        Console.WriteLine(a);
    }
    static void Main(string[] args)
    {
        int value;
        PassbyOut(out value);
        Console.WriteLine(value);
    }
}

