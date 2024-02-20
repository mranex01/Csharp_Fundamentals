namespace Multiple_Inheritance;
class person
{
    public void show()
    {
        Console.WriteLine("this is parent class");
    }
}


interface employee
{
    void show1();
}

class teacher: person,employee
{
    public void show1()
    {
        Console.WriteLine("this is employe Interface");
    }
}
class Program
{
    static void Main(string[] args)
    {
        teacher t = new teacher();
        t.show();
        t.show1();

        Console.ReadLine();
    }
}

