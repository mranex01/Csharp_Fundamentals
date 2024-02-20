namespace Ascending_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 4, 2, 3, 1 };
        Console.WriteLine("original Array");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+ " ");
        }

        
        int temp=0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j <arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Asceding Order");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+ " ");
        }
    }
}

