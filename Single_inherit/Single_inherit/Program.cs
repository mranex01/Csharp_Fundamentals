namespace Single_inherit;
class car 
{
    public int model;
    public string name;
    public int price;

    public void ShowCar()
    {
        Console.WriteLine("Car Model: "+model);
        Console.WriteLine("Car Name : "+name);
        Console.WriteLine("Car Price : "+price);
    }
    
}

class suzuki : car
{
    public int avg;

    public void suzukidetails()
    {
        Console.WriteLine("Car Average: "+avg);
    }

    public void getdetail()
    {
        Console.WriteLine("Enter Model Year: ");
        model = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Model Name : ");
        name = (Console.ReadLine());

        Console.WriteLine("Enter car price : ");
        price = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter car avg : ");
        avg= int.Parse(Console.ReadLine());
    }
}
class Program
{
    static void Main(string[] args)
    {

        suzuki s = new suzuki();
        s.getdetail();
        s.ShowCar();
        s.suzukidetails();


    }
}

