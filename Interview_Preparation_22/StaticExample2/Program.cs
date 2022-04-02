using System;

namespace StaticExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);

        
            circle.CalculateArea();

            Circle circle2 = new Circle(6);
            circle2.CalculateArea();

        }
    }
    public class Circle
    {
        public static double pi;
        private double radius;

        static Circle()
        {
            pi = 3.1416;
            Console.WriteLine("Static Constructor called");
        }

        public Circle(double radius)
        {
            this.radius = radius;
            Console.WriteLine("Constructor called");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"result : {pi * radius}");
        }

    }
}
