using System.Text;

namespace StringBuilder_Demo;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hii Aniket");
        sb.Append(" Adavkar ");
        sb.AppendLine("ICH");
        sb.Insert(3, " Mr");

        

        StringBuilder sb1 = new StringBuilder("Amount Is : ");
        sb1.AppendFormat("{0:C}", 96);

        Console.WriteLine(sb);
        Console.WriteLine(sb1);

        StringBuilder sb2 = new StringBuilder("Programing in in Java");
        sb2.Remove(11, 2);
        sb2.Replace("Java", "C#");
        Console.WriteLine(sb2);

        StringBuilder sb3 = new StringBuilder("Hiii Aniket");
        string a = sb3.ToString();
        Console.WriteLine(a);





    }
}

