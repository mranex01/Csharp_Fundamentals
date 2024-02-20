namespace Multiple_Delegate;

public delegate void Calculation(int a, int b);
public delegate void showD();
public delegate void Sq_cube(int a);
class Program
{
    public static void show()
    {
        Console.WriteLine("Show method ");
    }
    public static void square(int a)
    {
        var result = a * a;
        Console.WriteLine("Square root of {0} is {1}",a,result);
    }
    public static void cube(int a)
    {
        var result = a * a*a;
        Console.WriteLine("Cube of {0} is {1}", a, result);
    }

    public static void addition(int a , int b)
    {
        var result = a + b;
        Console.WriteLine("Addition is "+result);
    }


    static void Main(string[] args)
    {
        Calculation c = new Calculation(Program.addition);
        c(10, 14);

        showD s = new showD(show);
        s.Invoke();

        Sq_cube sc = new Sq_cube(square);
        sc(5);

        Sq_cube sc1 = new Sq_cube(cube);
        sc1(5);


    }
}

