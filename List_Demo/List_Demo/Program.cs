namespace List_Demo;

class Program
{
    static void Main(string[] args)
    {
        // List<int> number = new List<int>();

        /* number.Add(10);
         number.Add(20);
         number.Add(60);

         foreach (var item in number)
         {
             Console.WriteLine(item);
         }*/
        student st = new student()
        {
            name = "Aniket Adavkar",
            idno = 27,
            branch = "Computer "
        };

        student st1 = new student()
        {
            name = " Anuradha Shinde ",
            idno = 25,
            branch=" Computer"
        };

        student st2 = new student()
        {
            name = " Kaustubh Joshi",
            idno = 28,
            branch = "Computer "
        };

        List<student> slist = new List<student>();

        slist.Add(st);
        slist.Add(st1);
        slist.Add(st2);

        foreach (var stud in slist)
        {
            Console.WriteLine("Student Name : {0}  Student Roll No : {1} Student Branch : {2}",stud.name,stud.idno,stud.branch);
        }
    }
}

