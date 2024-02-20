namespace Nestes_If_Demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Number:");
        int number = int.Parse(Console.ReadLine());

        if(number>10)
        {
            if(number==12)
            {
                Console.WriteLine("Number is 12");
            }
            else
            {
                Console.WriteLine("Number is not 12");
            }
        }
        else if (number<10)
        {
            if (number==1)
            {
                Console.WriteLine("number is 1");
            }
            else
            {
                Console.WriteLine("number is not 1");
            }
        }else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}

