namespace FactorialNo;

class Program
{
    static void Main(string[] args)
    {
        int fact = 1;
        Console.WriteLine("Enter The number");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <=num; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Fact No: "+fact);
        Console.ReadLine();
    }
}

