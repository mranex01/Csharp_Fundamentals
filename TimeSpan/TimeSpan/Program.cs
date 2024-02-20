namespace TimeSpanex;

class Program
{
    static void Main(string[] args)
    {
        TimeSpan t1 = new TimeSpan(1, 30, 0);
        TimeSpan t2 = new TimeSpan(1, 10, 0);

        //add
        TimeSpan t3 = t1.Add(t2);

        //substract
        TimeSpan t4 = t1.Subtract(t2);

        //compare
        int comp = TimeSpan.Compare(t1, t2);

        //EQUALS
        var eq = t1.Equals(t2);

        //ToString
        var t5 = t1.ToString();

        //Parse
        var t6 = TimeSpan.Parse(t5);


        Console.WriteLine("Addition of t1 & t2:"+t3);
        Console.WriteLine("Substraction :"+t4);
        Console.WriteLine("COMPARE:"+comp);
        Console.WriteLine("Equals"+eq);
        Console.WriteLine("ToString:"+t5);
        Console.WriteLine("Parse"+t6);

        DateTime dt1 = DateTime.Now;
        DateTime dt2 = DateTime.UtcNow;

        TimeSpan ts1 = dt1 - dt2;
        Console.WriteLine("DIFF BETWEEN Local And Utc Time:"+ts1);






    }
}

