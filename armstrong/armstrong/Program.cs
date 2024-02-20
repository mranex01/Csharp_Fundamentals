namespace armstrong;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        int num = 371;
        var sum = 0;
        var temp = num;
        
            while(num>0)
            {
                var rem = num % 10;
                sum = (int)(sum +Math.Pow(rem,3));
                num = num / 10;
            }
        
        if(temp==sum)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        Console.ReadLine();
    }
}

