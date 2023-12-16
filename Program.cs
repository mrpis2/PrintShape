class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j > i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

        }
        Console.WriteLine("");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

        }
    }

}