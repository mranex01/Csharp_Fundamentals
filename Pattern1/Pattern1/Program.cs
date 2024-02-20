namespace Pattern1;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Enter No Of Row");
        int row = int.Parse(Console.ReadLine());

        for (int i = 1; i <= row; i++)
        {
            for (int j = 1; j <=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();*/

        //Console.WriteLine("Enter No Of Row");
        int row = 5;
            //int.Parse(Console.ReadLine());

        for (int i = 0; i < row; i++)
        {
            for (int j = row; j>i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

