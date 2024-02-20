namespace Bank_Encap;
class Account
{
    private int Ac_bal;

    public void SetDeposite(int a)
    {
        if(a<0)
        {
            Console.WriteLine("Enter More Than 0 Rupee");
        }
        else
        {
            Ac_bal = Ac_bal + a;
        }
    }

    public void GetBal()
    {
      
        Console.WriteLine("Account Balence Is : {0}",Ac_bal);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Account ac = new Account();
        
        ac.SetDeposite(-100);
        ac.GetBal();
    }
}

