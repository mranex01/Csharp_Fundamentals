namespace RestartingDemo;

class Program
{
    static void Main(string[] args)
    {
        string con;
        do
        {
            Console.WriteLine("Enter First Number");
            var num1 = Console.ReadLine();

            Console.WriteLine("Enter First Number");
            var num2 = Console.ReadLine();

            var add = num1 + num2;
            Console.WriteLine("Addition  Is: "+add);

            Console.WriteLine("Do You Want Reppeat YES/NO");
           con = Console.ReadLine().ToLower();


        } while ( con == "yes" );
        

            Console.WriteLine("Thank you ");
        
    }
}

