namespace Dest_Demo;
class Student
{

    public int roll;
    public string name;

    public Student(int roll, string name)
    {
        this.roll = roll;
        this.name = name;
    }

    public void getinfo()
    {
        Console.WriteLine("Roll no : {0}", roll);
        Console.WriteLine("Name Is : {0}", name);
    }

    ~Student()
    {
        Console.WriteLine("Destroy the Object");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(101, "Aniket");
            Student s2 = new Student(102, "Anu");
            s1.getinfo();
            s2.getinfo();
        }
    }
}
