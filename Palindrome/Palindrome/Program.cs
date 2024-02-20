namespace Palindrome;

class Program
{
    static void Main(string[] args)
    {
        
        
        var sum = 0;

        Console.WriteLine("Enter Number");
        int num = int.Parse(Console.ReadLine());
        var temp = num;

        while (num>0)
        {
            var rem = num % 10;
            sum = (sum * 10) + rem;
            num = num / 10;
            

        }
        if (temp == sum )
        {
            Console.WriteLine("Palindrome Number");
        }
        else
        {
            Console.WriteLine("Not Palindrom Number");
        }
        Console.ReadLine();

    }
}

