namespace PassByRef;

class Program
{

    public static void PassbyRef(ref int a)
    {

        a = a + 10;
        Console.WriteLine(a);
    }
    static void Main(string[] args)
    {
        int value = 10;

        PassbyRef(ref value);

        Console.WriteLine(value);
    }
}

