namespace Lambda_Expression;
public delegate void  Mydelegate(int num);
class Program
{
    static void Main(string[] args)
    {
        //lambda Expression
        Mydelegate obj = (a) =>
        {
            var result = a * a;
            Console.WriteLine(result);
        };
        obj.Invoke(5);

        //Statement Lambada Expression
        /*
        Mydelegate obj = (a) =>
        {
            var result = a * a;
            Console.WriteLine(result);
        };
        obj(5);
        */

        //Expression Lambda
        /*
        Mydelegate obj1 = (a) => a * a;
       
        Console.WriteLine(obj1.Invoke(5));
        */

        

    }
}

