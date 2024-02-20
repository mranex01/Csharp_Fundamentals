namespace Multilevel_inher;

class sumA
{
    public int a;

   

    public void showA()
    {
        Console.Write("Enter Value Of A: ");
        a = int.Parse(Console.ReadLine());

    }
}
class sumB : sumA
{
    public int b;

   

    public void showB()
    {
        Console.Write("Enter Value Of B: ");
        b = int.Parse(Console.ReadLine());

    }
}

class sumC : sumB
{
    public int c;

    public void getC()
    {
        c = a + b;

        Console.WriteLine("Addition Of A & B " + c);
    }

    
}
    class Program
{
    static void Main(string[] args)
    {
        sumC c1 = new sumC();

        c1.showA();
        c1.getA();
        c1.showB();
        c1.getB();
        
        c1.getC();
    }
}

