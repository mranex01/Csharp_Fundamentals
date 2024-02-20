namespace Auto_set_get;
class Student
{
    public string Fname { get; set; }
    public string Lname { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Fname = "aniket";
        s.Lname = "Adavkar";

        Console.WriteLine("Name is: "+s.Fname);
        Console.WriteLine("Last name "+s.Lname);
    }
}

