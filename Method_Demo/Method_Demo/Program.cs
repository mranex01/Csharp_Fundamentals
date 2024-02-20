namespace Method_Demo;

class Program
{
    public static void add(int num1, int num2)
    {
        int add1 = num1 + num2;
        Console.WriteLine("Addition:"+add1);
    }
    public static void show_age_name(int age, string name)
    {
        Console.WriteLine("AGE IS :"+age);
        Console.WriteLine("NAME IS : "+name);
    }
    static void Main(string[] args)
    {
        Program.show_age_name(22, "Aniket");

        Program.show_age_name(name:"Aniket", age:22);//names argument 

        
    }
}

