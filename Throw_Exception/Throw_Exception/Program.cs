namespace Throw_Exception;

class Program
{
    static void Main(string[] args)
    {
        var acc_bal = 5000;
        var with_amm=6000;

        try
        {
            if (acc_bal > with_amm)
            {
                acc_bal = acc_bal - with_amm;
                Console.WriteLine("Remaining Bal= " + acc_bal);
            }
            else
            {
                throw new Exception("Low Bal");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();

    }
}

