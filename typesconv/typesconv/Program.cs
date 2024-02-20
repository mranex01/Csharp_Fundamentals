internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string str = "true";
            bool b = Convert.ToBoolean(str);
            Console.WriteLine(b);
        }
        catch(Exception)
        {
            Console.WriteLine("The number could not be converted ");
        }
        }
        
}