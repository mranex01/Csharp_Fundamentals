namespace SwapToNO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter The Second number");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Before Swap Number 1 Is : {0} & Number 2 Is : {1} ",num1,num2);
        //swapping
        num1 = num1 * num2;
        num2 = num1 / num2;
        num1 = num1 / num2;

        Console.WriteLine("After Swapping Number 1 Is : {0} & Number 2 Is : {1} ",num1,num2);
        Console.ReadLine();
    }
}

