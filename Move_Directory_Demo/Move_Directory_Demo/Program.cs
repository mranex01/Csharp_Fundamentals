namespace Move_Directory_Demo;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/Aniket";
        String Path2 = "/Users/aniket/Documents/Aniket2";

        DirectoryInfo dir = new DirectoryInfo(path);
        dir.MoveTo(Path2);
        Console.WriteLine("Directory Moved");
    }
}

