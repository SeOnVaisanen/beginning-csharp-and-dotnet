namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;
            Console.WriteLine("Enter the first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number:");
            fourthNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The product of the numbers is: {firstNumber * secondNumber * thirdNumber * fourthNumber}.");
            Console.ReadKey();
        }
    }
}
