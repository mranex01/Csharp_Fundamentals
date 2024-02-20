namespace Rectangular_Array;

class Program
{
    static void Main(string[] args)
    {
        int[,] number = new int[3, 4]
        {
            {12,21,12,21 },
            {21,12,21,12 },
            {12,21,12,21 }
        };

        for (int i = 0; i <number.GetLength(0); i++)
        {
            for (int j = 0; j < number.GetLength(1); j++)
            {
                Console.Write(number[i,j] + " ");


            }
            Console.WriteLine();
        }
    }
}

