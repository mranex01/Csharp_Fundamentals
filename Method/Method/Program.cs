namespace Method;
class Employee
{
    public string Fname;
    public string Lname;

    public void show()
    {
        Console.WriteLine(Fname+ " "+Lname);
    }
}
class PartEmp : Employee
{
    public new  void  show()
    {
        base.show();
        //Console.WriteLine(Fname+ " "+Lname + " PTE");
    }
}

class FullEmp : Employee
{
    public new void show()
    {
        Console.WriteLine(Fname+"  "+Lname+ " FTE");
    }
}

class Program
    {
        static void Main(string[] args)
        {
        PartEmp pe = new PartEmp();

            pe.Fname = "aniket";
            pe.Lname = "adavkar";
        Console.WriteLine();
        pe.show();

        }
    }

