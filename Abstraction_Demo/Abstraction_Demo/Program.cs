namespace Abstraction_Demo;
class Employee
{
    public int Eid;
    public string Ename;
    double NetSalary;
    public double GrossSalary;
    double tax = 0.1;//10%

    public Employee(int Eid , string Ename, double GrossSalary)
    {
        this.Eid = Eid;
        this.Ename = Ename;
        this.GrossSalary = GrossSalary;
    }

    private void CalSalary()
    {
        if(GrossSalary>=30000)
        {
            NetSalary = GrossSalary - (tax * GrossSalary);
            Console.WriteLine("Employee Salary Is {0}",NetSalary);
            
        }
        else
        {
            Console.WriteLine("Employee Salary Is {0}",GrossSalary);
        }
    }

    public void show()
    {
        Console.WriteLine("Employee ID : {0}",Eid);
        Console.WriteLine("Employee Name : {0}",Ename);
        this.CalSalary();

    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(101, "aniket", 40000);
        emp.show();
        Console.ReadLine();
    }
}

