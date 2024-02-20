namespace Abstract_Prop;

abstract class details
{
    public abstract int id { get; set; }
    public abstract string name { get; set; }

}

class Student : details
{
    int studentid;
    string name1;

    public override int id
    {
        set
        {
            if(value<0)
            {
                Console.WriteLine("Enter correct id ");
            }
            else
            {
                this.studentid = value;
            }
            
        }
        get
        {
            return this.studentid;
        }
    }

    public override string name
    {
        set
        {
            if (string.IsNullOrEmpty(value)==true)
            {
                Console.WriteLine("Enter Correct name ");
            }
            else
            {
                this.name1 = value;
            }
            
        }
        get
        {
            return this.name1;
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.name = "aniket";
        s.id = -1;
        Console.WriteLine("Id is "+s.id);
        Console.WriteLine("Name is "+s.name);
        Console.ReadLine();

    }
}

