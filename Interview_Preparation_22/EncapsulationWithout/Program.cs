using System;

namespace EncapsulationWithOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lineSegment = new LineSegment();
            lineSegment.Start = new Point() { x = 5, y = 10 };
            lineSegment.End = new Point() { x = 8, y = 5 };

            Console.Write(Length(lineSegment));  
        }
        static float Length(LineSegment line)
        {
            var xCoordDiff = line.End.x - line.Start.y;
            var yCoordDiff = line.End.y - line.Start.x;
            return (float)Math.Sqrt((xCoordDiff * xCoordDiff) + (yCoordDiff * yCoordDiff));
        }
    }
    public class Point
    {
        public float x;
        public float y;
    }
    public class LineSegment
    {
        public Point Start;
        public Point End;
    }
}
