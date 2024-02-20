using System.Text;

namespace FileAccess_Demo;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/FileAccess.txt";
        using(FileStream file = new FileStream(path , FileMode.Create))
        {
            string data = " Aniket Datta Adavkar";
            byte[] write_Data = Encoding.UTF8.GetBytes(data);
            file.Write(write_Data, 0, data.Length);
            Console.WriteLine("Data Write Successfully");
        }
    }
}

