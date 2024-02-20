namespace CalculatorDemo;

class Program
{
    public static void Addition(int a, int b)
    {
        int result  = a + b;
        Console.WriteLine("Additon is:{0} "+result);

    }

    public static void Substraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine("Substraction is: {0}" + result);

    }

    public static void AMultiplication(int a, int b)
    {
        int result = a * b;
        Console.WriteLine("Multiplication is: {0}" + result);

    }

    public static void Division(int a, int b)
    {
        int result = a / b;
        Console.WriteLine("Division is: {0}" + result);

    }


    static void Main(string[] args)
    {
        string con;
        do
        {
            Console.WriteLine("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number :");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select Operator;");
            string op = Console.ReadLine();

            if (op.Equals("+"))
            {
                Program.Addition(num1, num2);
            }
            else if (op.Equals("-"))
            {
                Program.Substraction(num1, num2);
            }
            else if (op.Equals("*"))
            {
                Program.AMultiplication(num1, num2);
            }
            else if (op.Equals("/"))
            {
                Program.Division(num1, num2);
            }
            else
            {
                Console.WriteLine("select right Operator");
            }

            Console.WriteLine("Repeat ? YES/NO");
            con = Console.ReadLine().ToLower();

        } while (con=="yes");
        {

            Console.WriteLine("Thank you");
        }
        

    }
}

