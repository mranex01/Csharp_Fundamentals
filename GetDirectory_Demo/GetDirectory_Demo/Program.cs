namespace GetDirectory_Demo;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/Aniket";

        DirectoryInfo dir = new DirectoryInfo(path);
        DirectoryInfo[] drs = dir.GetDirectories();

        foreach (var item in drs)
        {
            Console.WriteLine(item);
        }

    }
}

