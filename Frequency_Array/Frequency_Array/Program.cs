namespace Frequency_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 1, 3, 2, 4, 4, 5 };

        int[] fr = new int[arr.Length];

        int visited = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 1;
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;

                    fr[j] = visited;
                }
            }
            if (fr[i] != visited)
                fr[i] = count;
        }

        //display
        Console.WriteLine("Frequency of array");
        
        for (int i = 0; i < fr.Length; i++)
        {
            if (fr[i] != visited)
                Console.WriteLine(" " + arr[i]+ "  |  " + fr[i]+ " " );
        }
    }
}

