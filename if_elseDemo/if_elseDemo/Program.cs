namespace if_elseDemo;

class Program
{
    static void Main(string[] args)
    {
        /*Login example
         
        Console.WriteLine("Enter Username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Password: ");
        String password = Console.ReadLine();

        if (username == "aniket" && password == "Aniket01")
        {
            Console.WriteLine("Login Succesfully.!!!!!!!!!!!!!!");
        }else
        {
            Console.WriteLine("Incorrect Username and Password ");
            Console.ReadLine();
        }*/

        //Number Validation

        /* Console.WriteLine("Enter The Number: ");
         int number = int.Parse(Console.ReadLine());

         if (number<=10)
         {
             Console.WriteLine("Valid Number ");

         }
         else
         {
             Console.WriteLine("Invalid Number  ");
         }*/

        //Maximum Number
        /*Console.WriteLine("Enter the first number:");
        int Number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second Number:");
        int Number2 = int.Parse(Console.ReadLine());

        if(Number1>Number2)
        {
            Console.WriteLine("Number 1 is Max number  ");
        }
        else
        {
            Console.WriteLine("Number 2 is Max number ");
        }*/

        // Landscape or portrait

        /*Console.WriteLine("Height Of Image:");
        int Height = int.Parse(Console.ReadLine());

        Console.WriteLine("Width of Image:");
        int Width = int.Parse(Console.ReadLine());

        if (Height==1080 && Width==560)
        {
            Console.WriteLine("Image Is Landscape....");
        }
        else if(Height==1080 && Width==1350)
        {
            Console.WriteLine("Image Is Portrait...");
        }
        else
        {
            Console.WriteLine("Incorrect Height and width");
        }
        */
        // Car speed limit

        Console.WriteLine(" Car Speed Limit Check Camera ");

        Console.WriteLine("Enter The car speed ");
        int speed = int.Parse(Console.ReadLine());

        if (speed <= 60)
        {
            Console.WriteLine("Speed Limit is OK ");
        }
        else
        {
            int demerits = (speed - 60) / 5;

            Console.WriteLine("Total Demerits:"+demerits);

            if (demerits>12)
            {
                Console.WriteLine("License in Suspended...!!!!!!!!!!");
            }

        }
    }
}

