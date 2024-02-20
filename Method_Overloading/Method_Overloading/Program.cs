namespace Method_Overloading;

class adddition
{

    public void add()
    {
        var a = 10;
        var b = 20;
        var c = a + b;
        Console.WriteLine(c);
    }

    public void add(int a, int b)
    {
        var c = a + b;
        Console.WriteLine(c);
    }

    public void add(string a, string b)
    {
        var c = a + " " + b;
        Console.WriteLine(c);

    }

    public void add(float a, float b)
    {
        var c = a + b;
        Console.WriteLine(c);
    }
}
class Program
{
    static void Main(string[] args)
    {
        adddition a = new adddition();
        a.add();
        a.add(1.5f, 3.5f);
        a.add(10, 12);
        a.add("Aniket", "Adavkar");
        
    }
}

