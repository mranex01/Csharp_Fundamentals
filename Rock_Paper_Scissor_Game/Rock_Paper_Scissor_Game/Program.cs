namespace Rock_Paper_Scissor_Game;
enum RPS
{
    rock,
    paper,
    scissor
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("|---------------------------|");
        Console.WriteLine("|----------Welcome----------|");
        Console.WriteLine("|--ROCK,PAPER,SCISSOR GAME--|");
        Console.WriteLine("|---------------------------|");

        while (true)
        {
            
            Console.WriteLine();
            Console.Write("Enter Your Choice:  ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            if (Enum.TryParse(choice, out RPS enumValue))
            {
                Random random = new Random();
                RPS obj = (RPS)random.Next(0, 3);
                Console.Write("Computer Choice: " + obj);

                
                Console.WriteLine();
                Console.WriteLine("Result: ");
                

                if (obj == enumValue)
                {
                    Console.WriteLine("GAME DRAW!!!!!");
                }
                else if (obj == enumValue + 1 || obj == enumValue + 2)
                {
                    Console.WriteLine("OHHH COMPUTER WIN..");
                    Console.WriteLine("BETTER LUCK NEXT TIME");
                }
                else
                {
                    Console.WriteLine("YAHHHH!! YOU WIN..");
                }
               
               

            }
            else
            {
                Console.WriteLine("Invalid Choice!!!!");
            }
           
            Console.WriteLine();

            Console.WriteLine("You Want to play again (Yes/No)");
            string input = Console.ReadLine().ToLower();

            if (input != "yes")
            {
                break;
            }
            Console.WriteLine("____________________________");



        }

        Console.ReadLine();
    }
}

