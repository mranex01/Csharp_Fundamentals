namespace TableDemo_for;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ENTER NUMBER: ");
        int number = int.Parse(Console.ReadLine());

        //Using for loop
        /*
        for(int i=1; i<=10; i++)
        {
            Console.WriteLine(number + " X " + i + " = "+ number*i);
        }
        */

        //Using while
        /*
        int i = 1;
        while (i<=10)
        {
            Console.WriteLine(number+ " X "+i + " ="+ number*i);
            i++;
        }*/


        //Using Do while
        int i = 1;
        do
        {
            Console.WriteLine(number + " X " + i + " = " + number * i);
            i++;

        } while (i<=10);
        Console.WriteLine("Table Created ");
    }
}

