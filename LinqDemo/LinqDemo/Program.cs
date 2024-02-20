namespace LinqDemo;

class Program
{
    static void Main(string[] args)
    {
        int[] age = { 22, 24, 21, 11, 10, 98 ,57, 54, 9, 66 };
        
        var a = from i in age where i > 20  select i;

        //sorting asc 
        var b = from i in age where i > 20 orderby i select i;
        //sorting dsc
        var c = from i in age where i > 20 orderby i descending select i;


        foreach (var item in c)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}

