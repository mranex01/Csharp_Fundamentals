namespace Jagged_Array;

class Program
{
    static void Main(string[] args)
    {
        int[][] number = new int[3][];

        number[0] = new[] { 12, 12, 13, 34, 43, 53 };
        number[1] = new[] { 13, 23, 13, 34 };
        number[2] = new[] { 24, 45, 56, 76, 98 };

        /* for (int i = 0; i < number.GetLength(0); i++)
         {
             for (int j = 0; j < number[i].Length; j++)
             {
                 Console.Write(number[i][j]+ " ");
             }
             Console.WriteLine();
         }*/

        foreach (var item in number)
        {
            foreach (var i in item)
            {
                Console.WriteLine(i+ " ");
            }
        }


            
    }
}

