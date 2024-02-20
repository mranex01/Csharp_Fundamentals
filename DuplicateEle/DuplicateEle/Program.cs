namespace DuplicateEle;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 1, 3, 2, 4, 4, 5 };

        Console.WriteLine("Duplicate Array Element");

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                Console.WriteLine( arr[j]);
            }
        }
    }
}

