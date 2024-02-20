namespace Exception_null;

class Program
{
    static void Main(string[] args)
    {
       
        try
        {
            Console.WriteLine("Enter name ");
            string name = Console.ReadLine();

            Console.WriteLine(name.Length);
            if(name==" ")
            {
                throw new NullReferenceException();
            }
            
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Null Reference Exception");
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}

