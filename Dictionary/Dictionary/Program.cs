namespace DictionaryDemo;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> data = new Dictionary<int, string>();

        data.Add(1, "Aniket Adavkar");
        data.Add(2, "Anuradha Shinde ");
        data.Add(3, "Varsha Devkar");
        data.Add(4, "Kaustubh Joshi ");

        /*foreach (var items  in data)
        {
            Console.WriteLine("Roll No: "+ items.Key + "   Student Name: "+items.Value);
        }*/

        string value;
        if(data.TryGetValue(1,out value))
        {
            Console.WriteLine(value);
        }else
        {
            Console.WriteLine("key Not found ");
        }
    }
}

