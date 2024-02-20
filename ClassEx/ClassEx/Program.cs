class Person
{
    public string FirstName;
    public string LastName;

    public void Introduction()
    {
        Console.WriteLine("Full Name : " + FirstName + " " + LastName);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Person aniket = new Person();
        aniket.FirstName = "Aniket";
        aniket.LastName = "Adavkar";
        aniket.Introduction();
    }
}