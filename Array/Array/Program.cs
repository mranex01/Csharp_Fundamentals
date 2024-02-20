namespace Array;

class Program
{
    static void Main(string[] args)
    {
        int[] number = {99,98,97,96};

        /*foreach (var item in number)
        {
            Console.WriteLine(item);
        }*/
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(number[i]);
        }

    }
}

