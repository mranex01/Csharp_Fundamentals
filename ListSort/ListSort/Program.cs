namespace ListSort;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        number.Add(50);
        number.Add(40);
        number.Add(30);
        number.Add(20);
        number.Add(10);
        Console.WriteLine("List before sorting ");
        foreach (var item in number)
        {
            Console.WriteLine(item);
        }


        number.Sort();
        Console.WriteLine("List after sorting");
        foreach (var s in number)
        {
            Console.WriteLine(s);
        }

    }
}

