namespace Property_Dir;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/Aniket/Aniket1";

        DirectoryInfo dir = new DirectoryInfo(path);

        Console.WriteLine(dir.Name);
        Console.WriteLine(dir.FullName);
        Console.WriteLine(dir.LastAccessTime);
        Console.WriteLine(dir.CreationTime);
        Console.WriteLine(dir.Attributes);
        Console.WriteLine(dir.Parent);
        Console.WriteLine(dir.Root);
        Console.WriteLine(dir.LastAccessTime);
    }
}

