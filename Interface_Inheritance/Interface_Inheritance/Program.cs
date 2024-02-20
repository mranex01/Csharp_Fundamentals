namespace Interface_Inheritance;
interface i1
{
    void print();
}
interface i2
{
    void print1();
}
interface i3 : i1,i2
{
    void print2();
}
class Program : i3
{
    public void print()
    {
        Console.WriteLine("Interface 1");
    }

    public void print1()
    {
        Console.WriteLine("Interface 2");
    }

    public void print2()
    {
        Console.WriteLine("Interface 3");
    }


    static void Main(string[] args)
    {
        i3 myterface = new Program();
        myterface.print();
        myterface.print1();
        myterface.print2();

        Console.ReadLine();
    }

    
}

