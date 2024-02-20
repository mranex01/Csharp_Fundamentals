namespace Encapsulation_Demo;
class person
{
    private string name;
    private int age;

    public void SetDetails(string name, int age)
    {
        

        if (string.IsNullOrEmpty(name)==true )
        {
            Console.WriteLine("Check Name  ");
            
        }
        else
        {
            this.name = name;
            
        }

        if(age>0)
        {
            Console.WriteLine("Check Age ");
        }
        else
        {
            this.age = age;
        }
    }

    public void GetDetails()
    {
        if (string.IsNullOrEmpty(this.name) == true)
        {
            
        }
        else
        {
            Console.WriteLine("Name is : " + name);
            
        }

        if(age>0)
        {

        }
        else
        {
            Console.WriteLine("Age Is :" + age);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        person p1 = new person();
        p1.SetDetails("", 21);
        p1.GetDetails();
    }
}

