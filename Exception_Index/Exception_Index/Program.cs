namespace Exception_Index;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[3];

        try
        {
            arr[0] = 10;
            arr[1] = 11;
            arr[2] = 12;
            arr[3] = 13;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Array out of bound ");
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Thank you!!!!");

        Console.ReadLine();
    }
}

