namespace Oprator_Overloading;

class Operator_over
{
    public string str;
    public int num;

    public static Operator_over operator +(Operator_over obj1,Operator_over obj2)
    {
        Operator_over obj3 = new Operator_over();
        obj3.str = obj1.str + obj2.str;
        obj3.num = obj1.num + obj2.num;
        return obj3;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operator_over obj1 = new Operator_over();
            obj1.str = "Aniket";
            obj1.num = 10;

            Operator_over obj2 = new Operator_over();
            obj2.str = " Adavkarr";
            obj2.num = 20;

            Operator_over obj3 = new Operator_over();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);

        }
    }
}

