namespace FileMode_Demo;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/Filemode.txt";

        using (FileStream file = new FileStream(path, FileMode.Truncate))//Use File.Append,Create,CreateNew,Open,OpenCreate
        {
            file.WriteByte(65);
            file.WriteByte(66);
            Console.WriteLine("File Truncate");
        }

    }
}

