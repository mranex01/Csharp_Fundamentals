namespace Explicitly_Interface;
interface i1
{
    void show();
}

interface i2
{
    void show();
}
class Program : i1, i2
{
    void i1.show()
    {
        Console.WriteLine("Interface 1 ");
    }

    void i2.show()
    {
        Console.WriteLine("Interface 2") ;
    }

    static void Main(string[] args)
    {
        i1 obj = new Program();
        obj.show();

        i2 obj2 = new Program();
        obj2.show();

        Console.ReadLine();
        
    }
}

