using System.IO;
namespace ReadData_Demo;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/Aniket1.txt";

        if(File.Exists(path))
        {
            Console.WriteLine("File Found");

            string data = File.ReadAllText(path);
            Console.WriteLine(data);
        }
        else
        {
            Console.WriteLine("File Not Found ");
        }
    }
}

