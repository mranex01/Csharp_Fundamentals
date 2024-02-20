namespace _2n;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input");
        int a = int.Parse(Console.ReadLine());

        int n1 = 0;
       int  n2 = 1;
        int n3=0;

        for (int i = 2; i <=a; i++)
        {
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;
        }

        Console.WriteLine(n3);
        Console.ReadLine();
    }
}

