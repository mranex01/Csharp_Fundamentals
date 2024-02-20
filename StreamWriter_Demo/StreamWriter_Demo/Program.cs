using System.Text;
using System.Text.Unicode;

namespace StreamWriter_Demo;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/StreamWriter.txt";

        using( FileStream file = new FileStream(path, FileMode.Append,FileAccess.Write))
        {
            using( StreamWriter write = new StreamWriter(file,Encoding.UTF8))
            {
                int[] arr = { 83, 08, 02, 86, 09 };
                foreach (var item in arr)
                {
                    write.WriteLine(item);
                }

                Console.WriteLine("File Created Successfully");
            }
        }
    }
}

