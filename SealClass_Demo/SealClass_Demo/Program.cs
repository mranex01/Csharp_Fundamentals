namespace SealClass_Demo;
sealed class BaseClass
{
   public void show()
    {
        Console.WriteLine("This Is a Base Class ");
    }
}

class DerivedClass: BaseClass
{
    public void show2()
    {
        Console.WriteLine( "  This is a chils class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        DerivedClass c = new DerivedClass();
        c.show();
        
    }
}

