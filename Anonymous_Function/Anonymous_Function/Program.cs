namespace Anonymous_Function;
public delegate void MyDelegate(int num);
class Program
{
    
    static void Main(string[] args)
    {
        MyDelegate d = delegate (int a)
        {
            a += 10;
            Console.WriteLine(a);
        };
        d(5);
    }
}

