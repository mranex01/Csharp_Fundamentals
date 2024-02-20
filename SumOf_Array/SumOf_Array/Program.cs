namespace SumOf_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];
        }
        Console.WriteLine("Sum of Array is : "+sum);
    }
}

