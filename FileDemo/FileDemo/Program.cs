using System.IO;
namespace FileDemo;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/Users/aniket/Documents/Aniket1.txt";

        if(File.Exists(path))
        {
            Console.WriteLine(" File Exists");
        }
        else
        {
            Console.WriteLine(" Not Exists");
        }
    }
}

