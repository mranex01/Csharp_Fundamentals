namespace Delete_Directory;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/Aniket2";

        DirectoryInfo dir = new DirectoryInfo(path);
        dir.Delete(true);
        Console.WriteLine("Directory Deleted. !!!!");
    }
}

