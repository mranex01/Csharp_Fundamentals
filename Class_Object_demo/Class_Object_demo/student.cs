namespace Class_Object_demo;

class student
{
    int roll;
    string name;
    int age;
    int standard;

    public void setinfo(int roll, string name, int age ,int standard)
    {
        this.roll = roll;
        this.name = name;
        this.age = age;
        this.standard = standard;

    }
    public void getinfo()
    {
        Console.WriteLine("Roll no is: {0}",roll);
        Console.WriteLine("name is: {0} ",name);
        Console.WriteLine("age is : {0}",age);
        Console.WriteLine("standard is : {0}",standard);
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Roll no:");
        int rollno = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter name:");
        var names = Console.ReadLine();

        Console.WriteLine("Enter Age :");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Standard:");
        int standard = int.Parse(Console.ReadLine());

        student st = new student();
        st.setinfo(rollno,names,age,standard);
        st.getinfo();

    }
}

