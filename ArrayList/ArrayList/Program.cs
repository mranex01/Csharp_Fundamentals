using System.Collections;
using System.Collections.Generic;

namespace ArrayList1;

class Program
{
    static void Main(string[] args)
    {
        ArrayList mylist = new ArrayList();

        mylist.Add(10);
        mylist.Add("Aniket");
        mylist.Add(2.65);

        mylist.Insert(3,96);
        mylist.Insert(4, 9696);
        mylist.Insert(5, "Adavkar");

        foreach (var obj in mylist)
        {
            Console.WriteLine(obj + " ");
        }

        Console.WriteLine("After insertion Capacity of arraylist: " + mylist.Capacity);

    }
}

