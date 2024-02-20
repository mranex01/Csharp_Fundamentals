namespace Prime_No;

class Program
{
    static void Main(string[] args)
    {
        int temp = 0;
        int num = 100;

        for (int i = 1; i <=num; i++)
        {
            if(num%i==0)
            {
                temp++;
            }
            
        }

        if (temp == 2)
        {
            Console.WriteLine("Prime Number ");
        }
        else
        {
            Console.WriteLine("Not a prime Number");
        }
        Console.ReadLine();

    }
}

