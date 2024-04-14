namespace EnumerationExample
{
    internal class Program
    {
        enum Orientation : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }

        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
            Orientation myDirection = Orientation.north;
            Console.WriteLine($"myDirection = {myDirection}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine($"byte equivalent = {directionByte}");
            Console.WriteLine($"string equivalent = {directionString}");
            Console.ReadKey();
        }
    }
}
