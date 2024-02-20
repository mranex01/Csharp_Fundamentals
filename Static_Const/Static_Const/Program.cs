namespace Static_Const;
class student
{
    public static int roll;
    public static string name;

    static student()
    {
        roll = 101;
        name = " Aniket";
        
        Console.WriteLine("Static Constructor Invoked");
    }

    public student()
    {
        Console.WriteLine("Default Constructor Invoked");
    }

    public static void getinfo()
    {
        Console.WriteLine("Student Roll No: {0}", roll);
        Console.WriteLine("Student Name : {0}", name);
    }


}
class Program
{
    static void Main(string[] args)
    {
        student s1 =new  student();
        student.getinfo();
    }
}

