namespace EvenPos;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Even position of array");
        for (int i = 1; i < arr.Length; i++)
        {
            if(i%2==0)

            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

