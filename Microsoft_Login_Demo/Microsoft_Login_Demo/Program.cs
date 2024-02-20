namespace Microsoft_Login_Demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To MICROSOFT");

        Console.WriteLine("Enter Mail:");
        string mail = Console.ReadLine();

        if (mail=="aniketadavkar1@gmail.com")
        {
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            if(password== "aniket01")
            {
                Console.WriteLine("Login succesfully");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
        else
        {
            Console.WriteLine("Invalid mail");
        }
    }
}

