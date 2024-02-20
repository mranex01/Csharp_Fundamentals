namespace EnumDemo;

enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday

        
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Name");
        string Name = Console.ReadLine();

        Console.WriteLine("Select Birth day Monday = 0 , Tuesday = 1, ....");
        int value = int.Parse(Console.ReadLine());

        Days mydays = (Days)value;
        Console.WriteLine("My name is : "+ Name + " " +"My Birth day is : "+mydays);

    }
}

