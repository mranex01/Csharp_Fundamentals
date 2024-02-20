namespace Finally_Exception;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var a = 5;
            var b = 2;
            var result = a / b;

            Console.WriteLine(result);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.......");
        }

        Console.ReadLine();
    }
}

