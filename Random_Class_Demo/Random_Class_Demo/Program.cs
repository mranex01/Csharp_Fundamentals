namespace Random_Class_Demo;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();

        /* for (int i = 0; i < 10; i++)
         {
             Console.Write((char)('a' + random.Next(0,9)));
         }*/

        //Password Using buffer Class
        const int passwordlenght = 8;

        var buffer = new Char[passwordlenght];

        for (int i = 0; i < passwordlenght; i++)

        {
           buffer[i]= (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.Write(password);

        }
    }
}

