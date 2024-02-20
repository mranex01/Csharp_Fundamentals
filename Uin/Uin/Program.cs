namespace Uin;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How Many numbers of data you want to store?");
        int num = int.Parse(Console.ReadLine());

        int[] numbers = new int[num];

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Enter The Data No "+ (i+1));
            int data = int.Parse(Console.ReadLine());
            numbers[i] = data;


        }
        Console.WriteLine("----------------- Your Data---------------");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}

