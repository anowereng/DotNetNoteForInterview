using System;

namespace OCP_Example_Of_Square_WithoutRefactore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();

            var areasRec = new[] { 
                new Rectangle() { Height = 10, Width = 50 },
                new Rectangle() { Height = 30, Width = 20 },
                new Rectangle() { Height = 40, Width = 50 },
                new Rectangle() { Height = 8,  Width = 50 },
            };
            var triangRec = new[] {
                new Triangle() { Height = 90, Width = 50 },
                new Triangle() { Height = 30, Width = 20 },
                new Triangle() { Height = 40, Width = 50 },
                new Triangle() { Height = 8,  Width = 50 },
            };

            var totalRecArea  =  areaCalculator.GetArea(areasRec);

            var totalTriangArea  =  areaCalculator.GetArea(triangRec);
            Console.WriteLine(totalTriangArea);
        }
    }
}
