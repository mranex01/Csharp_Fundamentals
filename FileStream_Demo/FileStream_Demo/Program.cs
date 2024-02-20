namespace FileStream_Demo;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/new.txt";
        using (FileStream file1 = new FileStream(path, FileMode.Create,FileAccess.Write))
        {
            file1.WriteByte(65);

            Console.WriteLine("File Created ");
        }
    }
}

