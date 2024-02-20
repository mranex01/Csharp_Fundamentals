internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Original Array");



        int[] arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] = i + 1);

        }

        Console.WriteLine("Reversearr");
        for (int j = arr.Length - 1; j >= 0; j--)
        {
            Console.WriteLine(arr[j]);
        }
        Console.ReadLine();
    }
}