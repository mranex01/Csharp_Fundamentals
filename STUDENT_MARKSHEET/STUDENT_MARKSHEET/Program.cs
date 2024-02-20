namespace STUDENT_MARKSHEET;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Class:");
        string clas = Console.ReadLine();

        Console.WriteLine("Enter Roll No:");
        string rn = Console.ReadLine();

        Console.WriteLine("Enter Java Marks");
        int j = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter python Marks");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter DBMS Marks");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter C# Marks");
        int c = int.Parse(Console.ReadLine());

        int obt = j + p + d + c;
        int per = obt * 100 / 400;

        Console.WriteLine("------------MARKSHEET--------------");
        Console.WriteLine(" ");
        Console.WriteLine("STUDENT NAME: {0}",name);
        Console.WriteLine("STUDENT CLASS: {0}", clas);
        Console.WriteLine("STUDENT ROLL NO : {0}", rn);
        Console.WriteLine( " ");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("STUDENT OBTAIN MARKS : {0}", obt);
        Console.WriteLine("STUDENT PERCENTAGE: {0}", per);

        //grade
        if (per>80)
        {
            Console.WriteLine("RESULT: First Class Dist");
        }
        else if (per>60)
        {
            Console.WriteLine("RESULT: First Class ");
        }
        else if (per >40)
        {
            Console.WriteLine("RESULT: Second Class ");
        }
        else
        {
            Console.WriteLine("RESULT: Fail");
        }

        //sub result
        if(j>40)
        {
            Console.WriteLine("SUBJECT: Java Fail");
        }
        else if (p > 40)
        {
            Console.WriteLine("SUBJECT: Python Fail");
        }
        else if (d > 40)
        {
            Console.WriteLine("SUBJECT: DBMS Fail");
        }
        else if (c > 40)
        {
            Console.WriteLine("SUBJECT:C# Fail");
        }

        //back
        int back = 0;

        if (j > 40)
        {
            back++;
        }
        if (p > 40)
        {
            back++;
        }
        if (d > 40)
        {
            back++;
        }
        if (c > 40)
        {
            back++;
        }
        Console.WriteLine("Total Back Subjects: {0}",back);

        if(back <= 2)
        {

            Console.WriteLine("RESULT: ATKT");

        } else if (back <= 3)
        {
            Console.WriteLine("RESULT: Carry On");
        }else
        {
            Console.WriteLine("RESULT: Year Down");
        }

    }
}

