internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 11, 22, 32, 45 };
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
            
        }
        Console.WriteLine("Largest Number In Array List: "+max);
    }
}