namespace FileReader;

class Program
{
    static void Main(string[] args)
    {
        string path = "/Users/aniket/Documents/StreamWriter.txt";
        using(FileStream file = new FileStream(path,FileMode.Open,FileAccess.Read))
        {
            using(StreamReader read = new StreamReader(file))
            {
                //Using While Loop
                /* string data = " ";
                 while((data=read.ReadLine())!=null)
                 {
                     Console.WriteLine(data);
                 }*/

                //Using Array

                /* string[] data = new string[10];

                 for (int i = 0; i < data.Length; i++)
                 {
                     data[i] = read.ReadLine();
                 }
                 foreach (var d in data)
                 {
                     Console.WriteLine(d);
                 }*/

                //using ReadToEnd()

                /*string data = read.ReadToEnd();
                Console.WriteLine(data);*/

                //Peek()
                if(read.Peek()>0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}

