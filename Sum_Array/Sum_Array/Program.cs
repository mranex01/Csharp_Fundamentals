namespace Sum_Array;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter The array Size ");
        int num = int.Parse(Console.ReadLine());

        int[] number = new int[num];

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Enter The number :");
            int data = int.Parse(Console.ReadLine());
            number[i]=data;
        }
        int sum = 0;
        foreach (var item in number)
        {
            sum += item;
        }

        Console.WriteLine("Sum of Array:"+sum);

    }
}

