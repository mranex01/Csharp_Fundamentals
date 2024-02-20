namespace Copy_Const;

class Program
{
    public int roll;
    public string name;

    public Program(int roll,string name)
    {
        this.roll = roll;
        this.name = name;
    }

    public Program( Program p)//copy constructor
    {
        this.roll = p.roll;
        this.name = p.name;
    }

    public void getinfo()
    {
        Console.WriteLine("Roll no is :{0}",roll);
        Console.WriteLine("Name is: {0}",name);
    }
    static void Main(string[] args)
    {
        Program p1 = new Program(101, "Aniket");
        Program p2 = new Program(p1);
        p1.getinfo();
        p2.getinfo();



    }
}

