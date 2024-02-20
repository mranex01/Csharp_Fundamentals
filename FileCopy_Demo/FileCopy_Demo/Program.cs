using System.IO;
namespace FileCopy_Demo;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/Aniket1.txt";

        string path1 = "/Users/aniket/Documents/NewAniket1.txt";

        File.Copy(path, path1,true);
    }
}

