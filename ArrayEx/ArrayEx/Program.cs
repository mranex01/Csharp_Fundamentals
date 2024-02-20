namespace ArrayEx;

class Program
{
    static void Main(string[] args)
    {
        //for int
        var numbers = new int[3];
        numbers[0] = 1;

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);

        //for bool
        var flags = new bool[3];
        flags[0] = true;

        Console.WriteLine(flags[0]);
        Console.WriteLine(flags[1]);
        Console.WriteLine(flags[2]);

        //for string
        var names = new string[3] { "Aniket", "Datta", "Adavkar" };

        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);

    }
}

