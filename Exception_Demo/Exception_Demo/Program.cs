
namespace Exception_Demo;


class Program
    {
    
        static void Main(string[] args)
        {
        Console.WriteLine("Enter First Number ");
        var num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number ");
        var num2 = int.Parse(Console.ReadLine());

        try
        {
            var result = num1 / num2;
            Console.WriteLine("Division is : "+result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Divide By Zero Exception Occure");
        }

        Console.WriteLine("Thank you!!!!!!!");
        Console.ReadLine();
    }
    }

