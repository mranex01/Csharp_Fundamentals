namespace Indexer_Demo;
class Employee
{ 

    private int[] age   = new int[3];

    public int  this[int index]
    {
        set
        {
            if (index >= 0 && index <= age.Length)
            {
                if (value > 0)
                {
                    age[index] = value;
                }
                else
                {
                    Console.WriteLine("Invalid age");
                }
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }
        get
        {
            return age[index];
        }
       
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp[0] = -5;
        Console.WriteLine(emp[0]);
        Console.ReadLine();

    }
}

