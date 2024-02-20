namespace PassByValue;

class Program
{

    public static void Passbyvalue(int a)
    {
        a = a + 10;
        Console.WriteLine(a);
    }

    static void Main(string[] args)
    {
        int value = 10;
        Passbyvalue(value);
        Console.WriteLine(value);
    }
}

