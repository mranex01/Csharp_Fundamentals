namespace Rotate_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original Array");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        int n=3;
        
        for (int i = 0; i < n; i++)
        {
            int  j,first;

            first = arr[0];

            for (int j = 0; j < arr.Length-1; j++)
            {
                arr[i] = arr[j+1];

            }
            arr[j] = first;
        }

        Console.WriteLine("Array Left rotation");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

