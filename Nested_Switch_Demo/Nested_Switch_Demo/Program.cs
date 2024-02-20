namespace Nested_Switch_Demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO PIZZA SHOP");
        Console.WriteLine("_________________________");

        Console.WriteLine("Select Pizza");
        string pizza = Console.ReadLine();

        switch (pizza)
        {
            case "special":
                Console.WriteLine("You Select Special Pizza ");
                break;

            case "veg":
                Console.WriteLine("Which Veg pizza you want");
                string veg = Console.ReadLine();
                
                switch (veg)
                {
                    case "paneer":
                        Console.WriteLine("You select Paneer Pizza");
                        break;

                    case "corn":
                        Console.WriteLine("You select corn pizza ");
                        break;

                    default:
                        Console.WriteLine(" you selected pizza not available");
                        break;

                }break;

            case "nonveg":
                Console.WriteLine("Which non Veg pizza you want ");
                string nonveg = Console.ReadLine();

                switch(nonveg)
                {
                    case "chicken":
                        Console.WriteLine("you select non veg pizza ");
                        break;

                    default:
                        Console.WriteLine("you selected pizza not available");
                        break;

                }break;
        }

    }
}

