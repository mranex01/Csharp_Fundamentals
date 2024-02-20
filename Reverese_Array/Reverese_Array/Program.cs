namespace Reverese_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original Array ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("Reverese Array");
        for (int j = arr.Length-1; j >= 0; j--)
        {
            Console.WriteLine(arr[j]);
        }
    }
}

