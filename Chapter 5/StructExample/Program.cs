namespace StructExample
{
    enum Orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    struct Route
    {
        public Orientation direction;
        public double distance;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1 North\n2) South\n3) East\n4) West");
            do
            {
                Console.WriteLine("Select a direction:");
                myDirection = Convert.ToInt32(Console.ReadLine());
            }
            while ((myDirection < 1) || (myDirection > 4));
            Console.WriteLine("Input a distance:");
            myDistance = Convert.ToDouble(Console.ReadLine());
            myRoute.direction = (Orientation)myDirection;
            myRoute.distance = myDistance;
            Console.WriteLine($"myRoute specifies a direction of {myRoute.direction} " +
                $"and a distance of {myRoute.distance}");
            Console.ReadKey();
        }
    }
}
