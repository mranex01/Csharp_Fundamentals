namespace String_Demo;

class Program
{
    static void Main(string[] args)
    {
        var name = " Aniket Adavkar ";
        var name2 = " aniket adavkar";
        var name3 = " Aniket Adavkar ";

        Console.WriteLine("My Name is : "+name);

        Console.WriteLine("Length Of String:"+name.Length);
        Console.WriteLine("Index Of A:"+name.IndexOf('A'));
        Console.WriteLine("End Index Of A:"+name.LastIndexOf('A'));
        Console.WriteLine("Name In Lower case:"+name.ToLower());
        Console.WriteLine("Name In Upper Case:"+name.ToUpper());
        Console.WriteLine("The Name is start with Aniket"+name.StartsWith("Aniket"));
        Console.WriteLine("The Name is end with Adavkar"+name.EndsWith("Adavkar"));
        Console.WriteLine("The Name Contains Aniket"+name.Contains("Aniket"));
        Console.WriteLine(" Name 1 Equals to Name 2"+name.Equals(name3));
        Console.WriteLine("Compare Name 1 and name 2: "+ name.CompareTo(name3));




    }
}

