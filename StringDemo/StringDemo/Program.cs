using System;
namespace StringDemo;

class Program
{
    static void Main(string[] args)
    {
        var FirstName = "Aniket";
        var LastName = "Adavkar";

        var FullName = (FirstName + " " + LastName);
        Console.WriteLine(FullName);

        var Full = string.Format("full name: {0} {1}", FirstName, LastName);
        Console.WriteLine(Full);

        var names = new string[3] { "Aniket", "Datta", "Adavkar" };
        var formatname = string.Join(",", names);
        Console.WriteLine(formatname);

        var text = @"aniket datta adavkar
Email:aniketadavkar1@gmail.com
Address: Ichalkaranji";
        Console.WriteLine(text);

    }
}

