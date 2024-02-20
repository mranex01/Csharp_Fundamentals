namespace Descending_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 4, 3, 5 };
        Console.WriteLine("Original Array:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");
        }

        var temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Descending Array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+ " ");
        }
    }
}

