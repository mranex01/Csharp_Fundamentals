namespace Method_Overriding;
class parent
{
    public virtual void print()
    {
        Console.WriteLine(" This is parent class ");
    }
}
class child: parent
{
    public override void  print()
    {
        Console.WriteLine(" THis is a child class ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        parent p = new child();
        p.print();

        
    }
}

