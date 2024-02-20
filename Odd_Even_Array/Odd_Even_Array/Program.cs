namespace Odd_Even_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        
        Console.WriteLine("Odd Numbers In Array:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]%2!=0)
            {
                Console.WriteLine(arr[i]);
            }
        }

        Console.WriteLine(" ");

        Console.WriteLine("Even Number In Array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]%2==0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

