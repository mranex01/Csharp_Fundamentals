namespace Instant_Static_demo;

class Program
{
    public int roll;
    public string firstName;
    public string LastName;
    public int age;
    public static string SchoolName="ABC School";
    public static int fee = 4000;

    public void FullName()
    {
        string FullName = this.firstName + " " + this.LastName;
        Console.WriteLine("Full Name :"+FullName);
    }

    public static int fees()
    {
        return fee;
    }

    static void Main(string[] args)
    {
        Program p1 = new Program();
        p1.roll = 101;
        p1.firstName = "Aniket";
        p1.LastName = "Adavkar";
        p1.age = 21;

        Console.WriteLine("Roll no:"+p1.roll);
        Console.WriteLine("Roll no:" + p1.firstName);
        Console.WriteLine("Roll no:" + p1.LastName);
        Console.WriteLine("Roll no:" + p1.age);
        Console.WriteLine("School name:"+Program.SchoolName);
        Console.WriteLine("Fees:"+Program.fee);
    }
}

