namespace CircleLabOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");

            double radius = Validator.GetValidRadius();

            Circle circle = new Circle(radius);

            DisplayCircleInfo(circle);

            while (Validator.ShouldCircleGrow())
            {
                circle.Grow();
                Console.WriteLine("The circle is magically growing.");
                DisplayCircleInfo(circle);
            }

            Console.WriteLine($"Goodbye. The circle’s final radius is {circle.GetRadius()}.");
        }

        static void DisplayCircleInfo(Circle circle)
        {
            Console.WriteLine("Diameter: " + circle.CalculateDiameter());
            Console.WriteLine("Circumference: " + circle.CalculateCircumference().ToString("F3"));
            Console.WriteLine("Area: " + circle.CalculateArea().ToString("F4"));
        }
    }
}