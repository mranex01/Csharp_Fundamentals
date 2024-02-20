namespace AbstractClass_demo;
abstract class person
{
    public string FirstName;
    public string LastName;
    public int age;
    public long PhoneNo;

    public abstract void PrintDetails();

}
class student : person
{
    public string Branch;
    public int Fees;

    public override void PrintDetails()
    {
        var name = FirstName + " " + LastName;
        Console.WriteLine("Student Name : {0} ",name);
        Console.WriteLine("Student Branch : {0} ",this.Branch);
        Console.WriteLine("Student Age : {0} ",this.age);
        Console.WriteLine("Student Phone No : {0} ", this.PhoneNo);
        Console.WriteLine("Student Fees : {0} ", this.Fees);
    }
    

}
class teacher : person
{
    public string subject;
    public int salary;

    public override void PrintDetails()
    {
        var name = FirstName + " " + LastName;
        Console.WriteLine("Teacher Name : {0} ", name);
        Console.WriteLine("Teacher Branch : {0} ", this.subject);
        Console.WriteLine("Teacher Age : {0} ", this.age);
        Console.WriteLine("Teacher Phone No : {0} ", this.PhoneNo);
        Console.WriteLine("Master In : {0} ",subject);
        Console.WriteLine("Teacher Salary : {0} ", this.salary);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----Student Details----- ");
        student s = new student();
        s.FirstName = "Aniket";
        s.LastName = "Adavkar";
        s.Branch = "Computer Enginnering";
        s.age = 21;
        s.PhoneNo = 8308028609;
        s.Fees = 640000;
        s.PrintDetails();

        Console.WriteLine("----------------------");

        Console.WriteLine("-----Teacher Details----- ");
        teacher t = new teacher();
        t.FirstName = "Anu";
        t.LastName = "Shinde";
        t.subject = "Java";
        t.age = 21;
        t.PhoneNo = 7666208711;
        t.salary = 60000;
        t.PrintDetails();

        Console.ReadLine();

    }
}

