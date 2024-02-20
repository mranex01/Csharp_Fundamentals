namespace OddPos_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 0,1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine("Odd Position of Array");
        for (int i = 0; i < arr.Length; i++)
        {
            if(i%2!=0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

