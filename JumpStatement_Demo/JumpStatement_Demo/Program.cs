namespace JumpStatement_Demo;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            if (i==5)
            {
                // break;
                //continue;
                goto stop;
            }
            Console.WriteLine(i);
        }

        stop:
        Console.WriteLine("Terminates");
    }
}

