namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;
            Console.WriteLine("Please enter two numbers:");
            do
            {
                var1 = Convert.ToInt32(Console.ReadLine());
                var2 = Convert.ToInt32(Console.ReadLine());
                if (var1 > 10 && var2 > 10)
                    Console.WriteLine("You need to enter another numbers!");
            }
            while (var1 > 10 && var2 > 10);

            if (var1 > 10 || var2 > 10)
                Console.WriteLine("One of the numbers is greater than 10.");
            Console.ReadKey();
        }
    }
}
