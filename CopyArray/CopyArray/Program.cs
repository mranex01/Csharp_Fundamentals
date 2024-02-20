namespace CopyArray;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 12, 11, 13, 14 };

        int[] arr2 = new int[arr1.Length];

        //copy
        for (int i = 0; i < arr1.Length; i++)
        {
            arr2[i] = arr1[i];

        }

        //arr1
        Console.WriteLine("Original Array List ");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i]+ " ");
        }
        Console.WriteLine(" ");
        //for display arr2
        Console.WriteLine("Copied Array List");
        for (int i = 0; i < arr1.Length; i++)
        {
            
            Console.Write(arr2[i]+" ");
        }

    }
}

