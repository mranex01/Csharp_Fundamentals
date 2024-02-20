namespace Hierarchical_inhe;
class RtoCar
{
    public int ModelYear;
    public int RegisterNo;
    public string State;

    public void ShowDetailsRto()
    {
        Console.WriteLine("Vehical Model Year: "+ModelYear);
        Console.WriteLine("Vehical Registration No: "+RegisterNo);
        Console.WriteLine("Vehical Registred State: "+State);
    }

    public void GetRtoDetails()
    {
        Console.Write("Enter Vehical Model Year: ");
        ModelYear = int.Parse(Console.ReadLine());

        Console.Write("Enter Vehical Registration No:  ");
        RegisterNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Vehical Registred state: ");
        State = Console.ReadLine();

    }
}

class Maruti : RtoCar
{
    public string ModelName;
    public int ModelAvg;
    public int ModelPrice;

    public void ShowMarutiDetails()
    {
        Console.WriteLine("Vehical Name : " + ModelName);
        Console.WriteLine("Vehical Average: " + ModelAvg);
        Console.WriteLine("Vehical Price: " + ModelPrice);
    }
    public void GetMarutiDetails()
    {
        Console.Write("Enter Vehical Name: ");
        ModelName = Console.ReadLine();

        Console.Write("Enter Vehical Average:  ");
        ModelAvg = int.Parse(Console.ReadLine());

        Console.Write("Enter Vehical Price: ");
        ModelPrice = int.Parse(Console.ReadLine());

    }


    class tata : RtoCar
    {
        public string TModelName;
        public int TModelAvg;
        public int TModelPrice;

        public void ShowtataDetails()
        {
            Console.WriteLine("Vehical Name : " + TModelName);
            Console.WriteLine("Vehical Average: " + TModelAvg);
            Console.WriteLine("Vehical Price: " + TModelPrice);
        }

        public void GetTataDetails()
        {
            Console.Write("Enter Vehical Name: ");
            TModelName = Console.ReadLine();

            Console.Write("Enter Vehical Average:  ");
            TModelAvg = int.Parse(Console.ReadLine());

            Console.Write("Enter Vehical Price: ");
            TModelPrice = int.Parse(Console.ReadLine());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Maruti m = new Maruti();
            tata t = new tata();


            Console.WriteLine("Select Brand Name 1.TATA 2.MARUTI");
            var ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                t.GetRtoDetails();
                t.GetTataDetails();
                t.ShowDetailsRto();
                t.GetTataDetails();
            }
            else if (ch == 2)
            {
                m.GetRtoDetails();
                m.GetMarutiDetails();
                m.ShowDetailsRto();
                m.ShowMarutiDetails();

            }
            else
            {
                Console.WriteLine("Wrong Brand");
            }

        }
    }
}

