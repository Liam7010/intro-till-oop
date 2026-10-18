namespace intro_till__oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Circle objects
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            // Display the areas
            Console.WriteLine($"Area of circle with radius 5: {circle1.GetArea()}");
            Console.WriteLine($"Area of circle with radius 6: {circle2.GetArea()}");

            Console.ReadKey();
        }

    }
}
