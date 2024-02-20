namespace ValueTypeDemo;

//In Reference Type Use class 

struct student
{
    public string name;
    public int age;
}
class Program
{
    static void Main(string[] args)
    {
        student s = new student();
        s.name = "Aniket";
        s.age = 21;

        student s1 = s;
        student s2 = s;
        s.name = "Annn";

        Console.WriteLine(s1.name);
        Console.WriteLine(s2.name);
        Console.WriteLine(s.name);




    }
}

