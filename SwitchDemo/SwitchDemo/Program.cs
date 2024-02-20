namespace SwitchDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Choice:");
        int day =int.Parse(Console.ReadLine());

        switch(day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("sunday");
                break;

            default:
                Console.WriteLine("Wrong Choice");
                break;
        }
    }
}

