namespace Static_prop;
class University
{
    private static string UniversityName;
    private static string CandidateName;

    public static string _UniversityName
    {
        set
        {
            if(string.IsNullOrEmpty(value)==true)
            {
                Console.WriteLine("Enter The UniverSity Name ");
            }
            else
            {
                UniversityName = value;
            }
        }
        get
        {
            return UniversityName;
        }
    }

    public static string _CandidateName
    {
        set
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                Console.WriteLine("Enter The Candidate Name ");
            }
            else
            {
                CandidateName = value;
            }
        }
        get
        {
            return CandidateName;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        University._UniversityName = "SPPU";
        University._CandidateName = "Aniket Adavkar";
        Console.WriteLine("University Name :"+University._UniversityName);
        Console.WriteLine("Candidate Name :"+University._CandidateName);
    }
}

