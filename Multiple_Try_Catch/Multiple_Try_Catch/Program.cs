namespace Multiple_Try_Catch;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            /*
            var a = 10;
            var b = 0;
            var result = a / b;*/

            /*
            string name = null;
            Console.WriteLine(name.Length);*/

            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;

            Console.WriteLine(arr.Length);


        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}

