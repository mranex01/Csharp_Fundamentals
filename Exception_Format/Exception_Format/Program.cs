namespace Exception_Format;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        string number = Console.ReadLine();

        
        try
        {
            int num = int.Parse(number);
            Console.Write("Number is : ");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Format Exception");
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
        
    }
}

