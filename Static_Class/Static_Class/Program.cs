namespace Static_Class;

static class Product
{
    public static int ProductId;
    public static string ProductName;
    public static int ProductPrice;

    static Product()
    {
        ProductId = 101;
        ProductName = "I Phone ";
        ProductPrice = 45000;
    }

    public static void GetDetails()
    {
        Console.WriteLine("Product Id :{0}",ProductId);
        Console.WriteLine("Product Name: {0}",ProductName);
        Console.WriteLine("Product Price:{0}",ProductPrice);
    }

    public static void GetDiscount()
    {
        var Discount = ProductPrice / 5;

        Console.WriteLine("Total Discount : {0}",Discount);
        Console.WriteLine("Paid Amount :{0}",(ProductPrice-Discount));
    }
       
}

class Program
{
    static void Main(string[] args)
    {
        Product.GetDetails();
        Product.GetDiscount();
    }
}

