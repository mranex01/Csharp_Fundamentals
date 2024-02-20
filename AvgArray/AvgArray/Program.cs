namespace AvgArray;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 12, 14, 15, 30 };

        Console.WriteLine("Average of arrray :" + numbers.Average());

        float sum = numbers.Sum();

        int count = numbers.Count();

        var avg = sum / count;

        Console.WriteLine("Average is ;"+avg);

    }


}

