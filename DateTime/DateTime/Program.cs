namespace DateTime1;

class Program
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;

        Console.WriteLine("GENERAL DATE AND TIME:  {0:G}",dt);
        Console.WriteLine("MONTH DAY: {0:m}", dt);
        Console.WriteLine("SHORT TIME: {0:t}",dt);
        Console.WriteLine("LONG TIME:{0:T}",dt);
        Console.WriteLine("YEAR MONTH PATTERN: {0:y}", dt);
        Console.WriteLine("SHORT NAME OF THE DAY : {0:ddd}", dt);
        Console.WriteLine("FULL NAME OF THE DAY: {0:dddd}", dt);


        Console.WriteLine("FRACTION SECONDS: {0:FF}", dt);
        Console.WriteLine("HOURS: {0:HH}", dt);
        Console.WriteLine("SECONDS: {0:ss}", dt);


        Console.WriteLine("MONTH IN NUMBER: {0:MM}", dt);
        Console.WriteLine("SHORT NAME OF MONTH: {0:MMM}", dt);

        //own defined
        Console.WriteLine("12HR FORMAT {0:HH:mm:ss tt}", dt);
        Console.WriteLine("24HR FORMAT {0:HH:mm:ss}", dt);

        Console.WriteLine("FULL DATE {0:dd:mm:yyyy}", dt);


    }
}

