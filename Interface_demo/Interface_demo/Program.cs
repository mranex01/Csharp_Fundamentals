namespace Interface_demo;
interface myinter
{
    void show();

}

class person : myinter
{
    public void show()
    {
        Console.WriteLine("This is interface method ");
    }
}
class Program
{

    static void Main(string[] args)
    {
        person p = new person();
        p.show();
        Console.ReadLine();

    }
}

