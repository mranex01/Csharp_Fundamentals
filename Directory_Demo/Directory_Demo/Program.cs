namespace Directory_Demo;

class Program
{
    static void Main(string[] args)
    {
        String path = "/Users/aniket/Documents/Aniket";

        DirectoryInfo dir = new DirectoryInfo(path);
        //dir.Create();
        dir.CreateSubdirectory("Aniket Subdirectory");
        Console.WriteLine("Directory Created !");
    }
}

