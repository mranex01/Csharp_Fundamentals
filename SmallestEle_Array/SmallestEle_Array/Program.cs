namespace SmallestEle_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 12, 11, 32, 45, 100 };
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        Console.WriteLine("Smallest Element In Array:"+min);
    }
}

