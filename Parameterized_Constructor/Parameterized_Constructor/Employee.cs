namespace Parameterized_Constructor;

class Employee
{
    int EmpId;
    string EmpName;
    int EmpAge;

    public Employee(int EmpId, string EmpName, int EmpAge)
    {
        this.EmpId = EmpId;
        this.EmpName = EmpName;
        this.EmpAge = EmpAge;

    }
    public void GetInfo()
    {
        Console.WriteLine("Employee Id :"+EmpId);
        Console.WriteLine("Employee Name :"+EmpName);
        Console.WriteLine("Employee Age :"+EmpAge);
    }
    static void Main(string[] args)
    {
        Employee e1 = new Employee(101,"Aniket",21);
        e1.GetInfo();

    }
}

