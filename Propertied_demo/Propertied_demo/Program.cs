namespace Propertied_demo;
class Student
{
    private int _StdId;
    private string _StdName;
    private string _StdLname;

    public int StdId
    {
        set
        {
            if(value<=0)
            {
                Console.WriteLine("Enter Correct value.");
            }
            else
            {
                this._StdId = value;
            }
        }

        get
        {
            return this._StdId;
        }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                Console.WriteLine("Enter Correct Name");
            }
            else
            {
                this._StdName = value;
            }
        }
        get
        {
            return this._StdName;
        }
    }

    public string LName
    {
        set
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                Console.WriteLine("Enter Correct Name");
            }
            else
            {
                this._StdLname = value;
            }
        }
        get
        {
            return this._StdLname;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.StdId = 101;
        s.Name = "Aniket";
        s.LName = "Adavkar";
        Console.WriteLine("Student Id Is: "+s.StdId);
        Console.WriteLine("Student Name Is : "+s.Name);
        Console.WriteLine("Student Last Name : "+s.LName);
    }
}

